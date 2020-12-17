using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Core.Jsons.Identify
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#identify-identify-structure
    /// </summary>
    public class DiscordIdentify
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("properties")]
        public IdentifyProperties Properties { get; set; }

        [JsonProperty("compress")]
        public bool? Compress { get; set; } = false;

        [JsonProperty("large_threshold")]
        public int? LargeThreshold { get; set; } = 50;

        [JsonProperty("shard")]
        public int[] Shard { get; set; }

        [JsonProperty("presence")]
        public object Presence { get; set; }

        [JsonProperty("guild_subscriptions")]
        public bool? GuildSubscriptions { get; set; } = true;

        [JsonProperty("intents")]
        public int Intents { get; set; }

        public DiscordIdentify()
        {
            Properties = new IdentifyProperties
            {
                OS = Environment.OSVersion.Platform.ToString(),
                Browser = "DiscordCs",
                Device = "DiscordCs"
            };
        }
    }
}
