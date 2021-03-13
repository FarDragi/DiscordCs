using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Converters;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using FarDragi.DiscordCs.Entity.Models.HelloModels;
using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Entity.Models.PayloadModels;
using FarDragi.DiscordCs.Entity.Models.ReadyModels;
using FarDragi.DiscordCs.Entity.Models.ResumeModels;
using FarDragi.DiscordCs.Gateway.Standard.Functions;
using FarDragi.DiscordCs.Logging;
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
    public class GatewayClient : IGatewayClient
    {
        private readonly IGatewayContext _gatewayContext;
        private readonly Identify _identify;
        private readonly GatewayConfig _config;
        private readonly ILogger _logger;
        private readonly ICacheContext _cacheContext;
        private readonly Decompressor _decompressor;
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        private readonly System.Diagnostics.Stopwatch _stopwatch;

        private WebSocket _socket;
        private CancellationTokenSource _tokenSource;
        private int _sequenceNumber;
        private bool _firstConnection;
        private string _sessionId;
        private long _ping;

        public GatewayClient(IGatewayContext gatewayContext, Identify identify, GatewayConfig config, ILogger logger, ICacheContext cacheContext)
        {
            _gatewayContext = gatewayContext;
            _identify = identify;
            _config = config;
            _logger = logger;
            _cacheContext = cacheContext;
            _firstConnection = true;
            _decompressor = new Decompressor();
            _jsonSerializerOptions = new JsonSerializerOptions()
            {
                Converters =
                {
                    new MemberCollectionConverter(_cacheContext),
                    new UserCollectionConverter(_cacheContext),
                    new ChannelCollectionConverter(_cacheContext),
                    new GuildChannelCollectionConverter(_cacheContext),
                    new ULongConverter(),
                    new TimeSpanConverter(),
                    new GuildChannelConverter()
                }
            };
            _stopwatch = new System.Diagnostics.Stopwatch();
        }

        #region Get/Set

        public long Ping { get => _ping; }
        public string SessionId { set => _sessionId = value; }

        #endregion

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
            if (_decompressor.TryDecompress(e.Data, out string json))
            {
                Payload<JsonElement> payload = JsonSerializer.Deserialize<Payload<JsonElement>>(json, _jsonSerializerOptions);

                _sequenceNumber = payload.SequenceNumber ?? _sequenceNumber;

                switch (payload.OpCode)
                {
                    case PayloadOpCode.Dispatch:
                        Received(payload, json);
                        break;
                    case PayloadOpCode.Hello:
                        Hello hello = payload.Data.ToObject<Hello>(_jsonSerializerOptions);
                        _tokenSource = new CancellationTokenSource();
                        Heartbeat(hello, _tokenSource.Token);
                        break;
                    case PayloadOpCode.HeartbeatACK:
                        _stopwatch.Stop();
                        _logger.Log(LoggingLevel.Info, $"Received heartbeat");
                        _ping = _stopwatch.ElapsedMilliseconds;
                        _stopwatch.Reset();
                        break;
                    case PayloadOpCode.InvalidSession:
                        _firstConnection = true;
                        _socket.Close();
                        break;
                    case PayloadOpCode.Reconnect:
                        break;
                    default:
                        break;
                }

                _logger.Log(LoggingLevel.Verbose, json);
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
                _logger.Log(LoggingLevel.Warning, $"Code: {args.Code} Reason: {args.Reason}\n");

                _socket.Dispose();
                _tokenSource.Cancel();
                InitSocket();
                _socket.Open();
            }
        }

        #endregion

        #region Recive/Send

        public void Received(Payload<JsonElement> payload, string json)
        {
            _logger.Log(LoggingLevel.Info, $"Received {payload.Event}");
            _gatewayContext.OnReceivedEvent(this, payload, json, _jsonSerializerOptions);
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

                    _stopwatch.Start();
                    Send(new PayloadHeartbeat
                    {
                        Data = _sequenceNumber
                    });
                    _logger.Log(LoggingLevel.Info, "Send heartbeat");
                }
            }
            catch (Exception)
            {
                _tokenSource.Dispose();
                return;
            }
        }

        #endregion

        #region On/Off

        public Task Open()
        {
            _logger.Log(LoggingLevel.Info, $"Start shard {_identify.Shard[0]}");
            InitSocket();
            _socket.Open();
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _socket?.Dispose();
            _tokenSource?.Cancel();
            _tokenSource?.Dispose();
        }

        #endregion
    }
}
