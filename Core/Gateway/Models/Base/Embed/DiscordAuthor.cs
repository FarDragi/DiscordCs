using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed
{
    internal class DiscordAuthor
    {
        [JsonProperty("name")]
        internal string Name { get; set; }

        [JsonProperty("url")]
        internal string Url { get; set; }

        [JsonProperty("icon_url")]
        internal string IconUrl { get; set; }

        [JsonProperty("proxy_icon_url")]
        internal string ProxyIconUrl { get; set; }
    }
}
