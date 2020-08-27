using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed
{
    internal class DiscordImage
    {
        // Discord Image
        [JsonProperty("url")]
        internal string Url { get; set; }

        // Discord Image
        [JsonProperty("proxy_url")]
        internal string ProxyUrl { get; set; }

        // Discord Image
        [JsonProperty("height")]
        internal uint Height { get; set; }

        // Discord Image
        [JsonProperty("width")]
        internal uint Width { get; set; }
    }
}
