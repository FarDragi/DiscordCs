using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base
{
    internal class DiscordHashe
    {
        [JsonProperty("omitted")]
        public bool IsOmitted { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}
