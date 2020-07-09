using Newtonsoft.Json;

namespace FarDragi.DragiCordApi.Core.Gateway.Models.Base
{
    internal class DiscordHashe
    {
        [JsonProperty("omitted")]
        public bool IsOmitted { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}
