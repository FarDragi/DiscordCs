using FarDragi.DiscordCs.Json.Entities.PresenceModels;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Json.Entities.IdentifyModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#identify-identify-structure
    /// </summary>
    public class JsonIdentify
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("properties")]
        public JsonIdentifyProperties Properties { get; set; }

        [JsonProperty("compress")]
        public bool Compress { get; set; }

        [JsonProperty("large_threshold")]
        public int LargeThreshold { get; set; }

        [JsonProperty("shard")]
        public int[] Shard { get; set; }

        [JsonProperty("presence")]
        public JsonPresenceStatusUpdate Presence { get; set; }

        [JsonProperty("guild_subscriptions")]
        public bool GuildSubscriptions { get; set; }

        [JsonProperty("intents")]
        public int Intents { get; set; }
    }
}
