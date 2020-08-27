using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed
{
    internal class DiscordThumbnail
    {
        // Discord Thumbnail
        [JsonProperty("url")]
        internal string Url { get; set; }

        // Discord Thumbnail
        [JsonProperty("proxy_url")]
        internal string ProxyUrl { get; set; }

        // Discord Thumbnail
        [JsonProperty("height")]
        internal uint Height { get; set; }

        // Discord Thumbnail
        [JsonProperty("width")]
        internal uint Width { get; set; }
    }
}
