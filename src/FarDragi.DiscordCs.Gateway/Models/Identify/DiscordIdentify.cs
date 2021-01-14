using FarDragi.DiscordCs.Core.Identify;
using FarDragi.DiscordCs.Core.Presence;
using FarDragi.DiscordCs.Gateway.Models.Presence;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Models.Identify
{
    public class DiscordIdentify
    {
        [JsonProperty("token")]
        public string token;

        [JsonProperty("properties")]
        public IdentifyProperties properties;

        [JsonProperty("compress")]
        public bool compress;

        [JsonProperty("large_threshold")]
        public int largeThreshold;

        [JsonProperty("shard")]
        public int[] shard;

        [JsonProperty("presence")]
        public PresenceStatusUpdate presence;

        [JsonProperty("guild_subscriptions")]
        public bool guildSubscriptions;

        [JsonProperty("intents")]
        public int intents;
    }
}
