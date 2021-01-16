using FarDragi.DiscordCs.Entities.PresenceModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.IdentifyModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#identify-identify-structure
    /// </summary>
    public class Identify
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("properties")]
        public IdentifyProperties Properties { get; set; }

        [JsonProperty("compress")]
        public bool Compress { get; set; }

        [JsonProperty("large_threshold")]
        public int LargeThreshold { get; set; }

        [JsonProperty("shard")]
        public int[] Shard { get; set; }

        [JsonProperty("presence")]
        public PresenceStatusUpdate Presence { get; set; }

        [JsonProperty("guild_subscriptions")]
        public bool GuildSubscriptions { get; set; }

        [JsonProperty("intents")]
        public IdentifyIntent Intents { get; set; }
    }
}
