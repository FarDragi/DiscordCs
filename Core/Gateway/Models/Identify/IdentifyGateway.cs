using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Identify
{
    internal sealed class IdentifyGateway
    {
        [JsonProperty("token")]
        internal string Token { get; set; }
        [JsonProperty("properties")]
        internal IdentifyConnectionProperties Properties { get; set; }
        [JsonProperty("compress")]
        internal bool Compress { get; set; }
        [JsonProperty("large_threshold")]
        internal uint LargeThreshold { get; set; }
        [JsonProperty("guild_subscriptions")]
        internal bool GuildSubscriptions { get; set; }
        [JsonProperty("shard")]
        internal uint[] Shards { get; set; }
        [JsonProperty("presence")]
        internal IdentifyPresence Presence { get; set; }
        [JsonProperty("intents")]
        internal uint Intents { get; set; }
    }
}
