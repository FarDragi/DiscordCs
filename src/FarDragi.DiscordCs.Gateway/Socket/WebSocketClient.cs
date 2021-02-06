using FarDragi.DiscordCs.Gateway.Payloads;
using FarDragi.DiscordCs.Json.Entities.HelloModels;
using FarDragi.DiscordCs.Json.Entities.IdentifyModels;
using FarDragi.DiscordCs.Json.Entities.ResumeModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SuperSocket.ClientEngine;
using System;
using System.Text;
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
        private readonly JsonIdentify _identify;
        private readonly WebSocketConfig _config;

        private CancellationTokenSource _tokenSource;
        private int _sequenceNumber;
        private bool _firstConnection;

        public WebSocketClient(GatewayClient gatewayClient, JsonIdentify identify)
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
            AddEvents();
        }

        private void AddEvents()
        {
            _socket = new WebSocket(_config.Url);
            _socket.Closed += Socket_Closed;
            _socket.Error += Socket_Error;
            _socket.Opened += Socket_Opened;
            _socket.DataReceived += Socket_DataReceived;
            _socket.MessageReceived += Socket_MessageReceived;
        }

        private void Socket_Closed(object sender, EventArgs e)
        {
            if (e is ClosedEventArgs args)
            {
                Console.WriteLine($"Code: {args.Code} Reason: {args.Reason}\n");

                _socket.Dispose();
                AddEvents();
                _socket.Open();

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
        }

        private void Socket_Error(object sender, ErrorEventArgs e)
        {
        }

        private void Socket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private void Socket_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (_decompress.TryDecompress(e.Data, out string json))
            {
                Payload<object> payload = JsonConvert.DeserializeObject<Payload<object>>(json);
                if (payload.SequenceNumber != null)
                {
                    _sequenceNumber = (int)payload.SequenceNumber;
                }

                Console.WriteLine(json);
                Console.WriteLine();

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

        private void Socket_Opened(object sender, EventArgs e)
        {
            if (_firstConnection)
            {
                Send(new IdentifyPayload
                {
                    Data = _identify
                });

                _firstConnection = false;
            }
        }

        public async void Heartbeat(JsonHello hello, CancellationToken token)
        {
            try
            {
                while (true)
                {
                    await Task.Delay(hello.HeartbeatInterval, token);
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
            string json = JsonConvert.SerializeObject(obj);

            Console.WriteLine(json);
            Console.WriteLine();

            byte[] payload = Encoding.UTF8.GetBytes(json);
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
