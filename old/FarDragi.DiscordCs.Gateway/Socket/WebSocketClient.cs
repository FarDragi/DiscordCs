using FarDragi.DiscordCs.Entities.IdentifyModels;
using FarDragi.DiscordCs.Gateway.Payloads;
using FarDragi.DiscordCs.Json.Entities.HelloModels;
using FarDragi.DiscordCs.Json.Entities.ResumeModels;
using SuperSocket.ClientEngine;
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using WebSocket4Net;

namespace FarDragi.DiscordCs.Gateway.Socket
{
    public class WebSocketClient : IDisposable
    {
        private WebSocket _socket;
        private readonly WebSocketDecompress _decompress;
        private readonly GatewayClient _gatewayClient;
        private readonly Identify _identify;
        private readonly WebSocketConfig _config;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        private CancellationTokenSource _tokenSource;
        private int _sequenceNumber;
        private bool _firstConnection;

        public WebSocketClient(GatewayClient gatewayClient, Identify identify)
        {
            _gatewayClient = gatewayClient;
            _identify = identify;
            _decompress = new WebSocketDecompress();
            _firstConnection = true;
            _config = new WebSocketConfig
            {
                Version = 8,
                Encoding = "json"
            };
            _jsonSerializerOptions = new JsonSerializerOptions
            {

            };
            AddEvents();
        }

        private void AddEvents()
        {
            _socket = new WebSocket(_config.Url);
            _socket.Closed += Socket_Closed;
            _socket.Error += Socket_Error;
            _socket.DataReceived += Socket_DataReceived;
            _socket.MessageReceived += Socket_MessageReceived;
        }

        private void Socket_Closed(object sender, EventArgs e)
        {
            if (e is ClosedEventArgs args)
            {
                Console.WriteLine($"Code: {args.Code} Reason: {args.Reason}\n");

                _socket.Dispose();
                _tokenSource.Cancel();
                AddEvents();
                _socket.Open();
            }
        }

        private void Socket_Error(object sender, ErrorEventArgs e)
        {
            _socket.Close();
        }

        private void Socket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private void Socket_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (_decompress.TryDecompress(e.Data, out string json))
            {
                Payload<object> payload = JsonSerializer.Deserialize<Payload<object>>(json, _jsonSerializerOptions);
                if (payload.SequenceNumber != null)
                {
                    _sequenceNumber = (int)payload.SequenceNumber;
                }

                switch (payload.OpCode)
                {
                    case PayloadOpCode.Dispatch:
                        _gatewayClient.OnEventReceived(payload.Event, (JObject)payload.Data, json);
                        break;
                    case PayloadOpCode.Hello:
                        _tokenSource = new CancellationTokenSource();
                        Heartbeat((payload.Data as JObject).ToObject<JsonHello>(), _tokenSource.Token);
                        break;
                    case PayloadOpCode.Reconnect:
                        break;
                    case PayloadOpCode.InvalidSession:
                        break;
                    case PayloadOpCode.HeartbeatACK:
                        break;
                    default:
                        break;
                }
            }
        }

        public async void Heartbeat(JsonHello hello, CancellationToken token)
        {
            try
            {
                if (_firstConnection)
                {
                    Send(new IdentifyPayload
                    {
                        Data = _identify
                    });

                    _firstConnection = false;
                }
                else
                {
                    Send(new ResumePayload()
                    {
                        Data = new JsonResume
                        {
                            SequenceNumber = _sequenceNumber,
                            SessionId = _gatewayClient.SessionId,
                            Token = _identify.Token
                        }
                    });
                }

                while (true)
                {
                    await Task.Delay(hello.HeartbeatInterval, token);
                    if (token.CanBeCanceled)
                    {
                        return;
                    }
                    Send(new HeartbeatPayload
                    {
                        Data = _sequenceNumber
                    });
                }
            }
            catch (Exception)
            {
                _tokenSource.Dispose();
                return;
            }
        }

        public async Task<bool> Open()
        {
            return await _socket.OpenAsync();
        }

        public void Send(object obj)
        {
            byte[] payload = JsonSerializer.SerializeToUtf8Bytes(obj, _jsonSerializerOptions);
            _socket.Send(payload, 0, payload.Length);
        }

        public void Dispose()
        {
            _socket.Dispose();
            if (_tokenSource != null)
            {
                _tokenSource.Dispose();
            }
        }
    }
}
