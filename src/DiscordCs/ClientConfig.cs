using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Entity.Models.PresenceModels;
using FarDragi.DiscordCs.Gateway;
using FarDragi.DiscordCs.Gateway.Standard;
using FarDragi.DiscordCs.Logging;
using FarDragi.DiscordCs.Logging.Standard;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs
{
    public class ClientConfig
    {
        private IGatewayContext _gateway;
        private ILogger _logger;
        private readonly Identify _identify;
        private LoggingLevel? _loggingLevel;

        public ClientConfig()
        {
            _identify = new Identify
            {
                IsCompress = true,
                Properties = new IdentifyProperties
                {
                    OS = Environment.OSVersion.Platform.ToString(),
                    Browser = "DiscordCs",
                    Device = "DiscordCs"
                },
                LargeThreshold = 50,
                Presence = new PresenceStatusUpdate
                {
                    Status = PresenceStatus.Online
                },
                Intents = IdentifyIntent.Default,
                IsGuildSubscriptions = false
            };
        }

        public Identify Identify { get => _identify; }
        public int Shards { get; set; } = 1;
        public IGatewayContext GatewayContext { set => _gateway = value; }
        public ILogger LoggerContext { set => _logger = value; }
        public LoggingLevel LoggingLevel { set => _loggingLevel = value; }
        public bool IsAutoSharding { get; set; } = true;
        public int[] Shard { get; set; }

        public IGatewayContext GetGatewayContext()
        {
            if (_gateway == null)
            {
                _gateway = new GatewayStandardContext(new GatewayStandardConfig
                {
                    BaseUrl = "wss://gateway.discord.gg",
                    Version = 8,
                    Encoding = "json"
                });
            }

            return _gateway;
        }

        public ILogger GetLogger()
        {
            if (_logger == null)
            {
                _logger = new LoggerStandard()
                {
                    Level = LoggingLevel.Warning
                };
            }

            if (_loggingLevel != null)
            {
                _logger.Level = (LoggingLevel)_loggingLevel;
            }

            return _logger;
        }

        public Identify GetIdentify(int[] shard)
        {
            return new Identify
            {
                Intents = _identify.Intents,
                IsCompress = _identify.IsCompress,
                IsGuildSubscriptions = _identify.IsGuildSubscriptions,
                LargeThreshold = _identify.LargeThreshold,
                Presence = _identify.Presence,
                Properties = _identify.Properties,
                Shard = shard,
                Token = _identify.Token
            };
        }
    }
}
