using FarDragi.DiscordCs.Entity.Models.PresenceModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.IdentifyModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#identify-identify-structure
    /// </summary>
    public class Identify
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("properties")]
        public IdentifyProperties Properties { get; set; }

        [JsonPropertyName("compress")]
        public bool IsCompress { get; set; }

        [JsonPropertyName("large_threshold")]
        public int LargeThreshold { get; set; }

        [JsonPropertyName("shard")]
        public int[] Shard { get; set; }

        [JsonPropertyName("presence")]
        public PresenceStatusUpdate Presence { get; set; }

        [JsonPropertyName("guild_subscriptions")]
        public bool IsGuildSubscriptions { get; set; }

        [JsonPropertyName("intents")]
        public IdentifyIntent Intents { get; set; }
    }
}
