using FarDragi.DiscordCs.Entity.Models.HelloModels;
using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Entity.Models.PayloadModels;
using FarDragi.DiscordCs.Gateway.Standard.Functions;
using System;
using System.Collections.Generic;
using System.IO;
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
        private JsonSerializerOptions _jsonSerializerOptions;

        public GatewayStandardClient(Identify identify, GatewayStandardConfig config)
        {
            _identify = identify;
            _config = config;
            _decompressor = new Decompressor();
            _jsonSerializerOptions = new JsonSerializerOptions()
            {
                Converters =
                {
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
                Receive(stream);
            }
        }

        private void Socket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            _socket.Close();
        }

        private void Ssocket_Closed(object sender, EventArgs e)
        {
            if (e is ClosedEventArgs args)
            {
                Console.WriteLine($"Code: {args.Code} Reason: {args.Reason}\n");

                _socket.Dispose();
                InitSocket();
                _socket.Open();
            }
        }

        #endregion

        #region Recive/Send

        public void Receive(ReadOnlySpan<byte> stream)
        {
            Payload payload = JsonSerializer.Deserialize<Payload>(stream, _jsonSerializerOptions);

            switch (payload.OpCode)
            {
                case PayloadOpCode.Dispatch:
                    break;
                case PayloadOpCode.Heartbeat:
                    break;
                case PayloadOpCode.Identify:
                    break;
                case PayloadOpCode.PresenceUpdate:
                    break;
                case PayloadOpCode.VoiceStateUpdate:
                    break;
                case PayloadOpCode.Resume:
                    break;
                case PayloadOpCode.Reconnect:
                    break;
                case PayloadOpCode.RequestGuildMembers:
                    break;
                case PayloadOpCode.InvalidSession:
                    break;
                case PayloadOpCode.Hello:
                    PayloadData<Hello> hello = JsonSerializer.Deserialize<PayloadData<Hello>>(stream, _jsonSerializerOptions);
                    break;
                case PayloadOpCode.HeartbeatACK:
                    break;
                default:
                    break;
            }
        }

        public void Send(object obj)
        {
            byte[] payload = JsonSerializer.SerializeToUtf8Bytes(obj, _jsonSerializerOptions);
            _socket.Send(payload, 0, payload.Length);
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
            _socket.Dispose();
            if (_tokenSource != null)
            {
                _tokenSource.Dispose();
            }
        }
    }
}
