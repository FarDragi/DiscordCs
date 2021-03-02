using FarDragi.DiscordCs.Entity.Converters;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using FarDragi.DiscordCs.Entity.Models.HelloModels;
using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Entity.Models.PayloadModels;
using FarDragi.DiscordCs.Entity.Models.ReadyModels;
using FarDragi.DiscordCs.Entity.Models.ResumeModels;
using FarDragi.DiscordCs.Gateway.Standard.Functions;
using SuperSocket.ClientEngine;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using WebSocket4Net;

namespace FarDragi.DiscordCs.Gateway.Standard
{
    public class GatewayStandardClient : IGatewayClient
    {
        private WebSocket _socket;
        private readonly Identify _identify;
        private readonly GatewayStandardConfig _config;
        private readonly Decompressor _decompressor;
        private CancellationTokenSource _tokenSource;
        private int _sequenceNumber;
        private bool _firstConnection;
        private string _sessionId;
        private JsonSerializerOptions _jsonSerializerOptions;

        public GatewayStandardClient(Identify identify, GatewayStandardConfig config)
        {
            _identify = identify;
            _config = config;
            _firstConnection = true;
            _decompressor = new Decompressor();
            _jsonSerializerOptions = new JsonSerializerOptions()
            {
                Converters =
                {
                    new ToULongConverter()
                }
            };
        }

        #region Events

        private void InitSocket()
        {
            _socket = new WebSocket(_config.GetUrl());
            _socket.Closed += Ssocket_Closed;
            _socket.Error += Socket_Error;
            _socket.DataReceived += Socket_DataReceived;
        }

        private void Socket_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (_decompressor.TryDecompress(e.Data, out ReadOnlySpan<byte> stream))
            {
                Payload<JsonElement> payload = JsonSerializer.Deserialize<Payload<JsonElement>>(stream, _jsonSerializerOptions);

                _sequenceNumber = payload.SequenceNumber ?? _sequenceNumber;

                switch (payload.OpCode)
                {
                    case PayloadOpCode.Dispatch:
                        Receive(payload);
                        break;
                    case PayloadOpCode.Hello:
                        Hello hello = payload.Data.ToObject<Hello>(_jsonSerializerOptions);
                        _tokenSource = new CancellationTokenSource();
                        Heartbeat(hello, _tokenSource.Token);
                        break;
                    case PayloadOpCode.HeartbeatACK:
                        break;
                    case PayloadOpCode.InvalidSession:
                        break;
                    case PayloadOpCode.Reconnect:
                        break;
                    default:
                        break;
                }
            }
        }

        private void Socket_Error(object sender, ErrorEventArgs e)
        {
            _socket.Close();
        }

        private void Ssocket_Closed(object sender, EventArgs e)
        {
            if (e is ClosedEventArgs args)
            {
                Console.WriteLine($"Code: {args.Code} Reason: {args.Reason}\n");

                _socket.Dispose();
                _tokenSource.Cancel();
                InitSocket();
                _socket.Open();
            }
        }

        #endregion

        #region Recive/Send

        public void Receive(Payload<JsonElement> payload)
        {
            if (payload.Event == "READY")
            {
                Ready ready = payload.Data.ToObject<Ready>(_jsonSerializerOptions);
                _sessionId = ready.SessionId;
            }
            else if (payload.Event == "GUILD_CREATE")
            {
                Guild guild = payload.Data.ToObject<Guild>(_jsonSerializerOptions);
            }
        }

        public void Send(object obj)
        {
            byte[] payload = JsonSerializer.SerializeToUtf8Bytes(obj, _jsonSerializerOptions);
            _socket.Send(payload, 0, payload.Length);
        }

        private async void Heartbeat(Hello hello, CancellationToken token)
        {
            try
            {
                if (_firstConnection)
                {
                    Send(new PayloadIdentify
                    {
                        Data = _identify
                    });

                    _firstConnection = false;
                }
                else
                {
                    Send(new PayloadResume
                    {
                        Data = new Resume
                        {
                            SequenceNumber = _sequenceNumber,
                            SessionId = _sessionId,
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

                    Send(new PayloadHeartbeat
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

        #endregion

        public Task Open()
        {
            Console.WriteLine("Abrindo...");
            InitSocket();
            _socket.Open();
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _socket?.Dispose();
            _tokenSource?.Dispose();
        }
    }
}
