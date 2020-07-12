using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base
{
    internal class DiscordGuildHashes
    {
        [JsonProperty("version")]
        public uint Version { get; set; }

        [JsonProperty("roles")]
        public DiscordHashe Roles { get; set; }

        [JsonProperty("metadata")]
        public DiscordHashe Metadata { get; set; }

        [JsonProperty("channels")]
        public DiscordHashe Channels { get; set; }
    }
}
