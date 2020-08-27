using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed
{
    internal class DiscordAuthor
    {
        // Discord Author
        [JsonProperty("name")]
        internal string Name { get; set; }

        // Discord Author
        [JsonProperty("url")]
        internal string Url { get; set; }

        // Discord Author
        [JsonProperty("icon_url")]
        internal string IconUrl { get; set; }

        // Discord Author
        [JsonProperty("proxy_icon_url")]
        internal string ProxyIconUrl { get; set; }
    }
}
