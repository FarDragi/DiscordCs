using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed
{
    internal class DiscordImage
    {
        [JsonProperty("url")]
        internal string Url { get; set; }

        [JsonProperty("proxy_url")]
        internal string ProxyUrl { get; set; }

        [JsonProperty("height")]
        internal uint Height { get; set; }

        [JsonProperty("width")]
        internal uint Width { get; set; }
    }
}
