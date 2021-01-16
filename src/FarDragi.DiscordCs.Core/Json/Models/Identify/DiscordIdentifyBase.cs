using FarDragi.DiscordCs.Core.Json.Models.Presence;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Json.Models.Identify
{
    public class DiscordIdentifyBase
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("properties")]
        public IdentifyPropertiesBase Properties { get; set; }

        [JsonProperty("compress")]
        public bool Compress { get; set; }

        [JsonProperty("large_threshold")]
        public int LargeThreshold { get; set; }

        [JsonProperty("shard")]
        public int[] Shard { get; set; }

        [JsonProperty("presence")]
        public PresenceStatusUpdateBase Presence { get; set; }

        [JsonProperty("guild_subscriptions")]
        public bool GuildSubscriptions { get; set; }

        [JsonProperty("intents")]
        public int Intents { get; set; }
    }
}
