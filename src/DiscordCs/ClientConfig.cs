﻿using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Caching.Standard;
using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Entity.Models.PresenceModels;
using FarDragi.DiscordCs.Gateway;
using FarDragi.DiscordCs.Gateway.Standard;
using FarDragi.DiscordCs.Logging;
using FarDragi.DiscordCs.Logging.Standard;
using FarDragi.DiscordCs.Rest;
using FarDragi.DiscordCs.Rest.Standard;
using System;

namespace FarDragi.DiscordCs
{
    public class ClientConfig
    {
        public ClientConfig()
        {
            Identify = new Identify
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
            GatewayContext = new GatewayContext(new GatewayConfig
            {
                BaseUrl = "wss://gateway.discord.gg",
                Version = 8,
                Encoding = "json"
            });
            Logger = new Logger
            {
                Level = LoggingLevel.Warning
            };
            CacheContext = new CacheContext(new CacheConfig
            {

            });
            Rest = new RestContext(new RestConfig
            {
                BaseUrl = "https://discord.com",
                Version = 8
            });
        }

        public Identify Identify { get; private set; }
        public int Shards { get; set; } = 1;
        public IGatewayContext GatewayContext { get; set; }
        public ICacheContext CacheContext { get; set; }
        public IRestContext Rest { get; set; }
        public ILogger Logger { get; set; }
        public bool IsAutoSharding { get; set; } = true;
        public int[] Shard { get; set; }

        public Identify GetIdentify(int[] shard)
        {
            return new Identify
            {
                Intents = Identify.Intents,
                IsCompress = Identify.IsCompress,
                IsGuildSubscriptions = Identify.IsGuildSubscriptions,
                LargeThreshold = Identify.LargeThreshold,
                Presence = Identify.Presence,
                Properties = Identify.Properties,
                Shard = shard,
                Token = Identify.Token
            };
        }
    }
}
