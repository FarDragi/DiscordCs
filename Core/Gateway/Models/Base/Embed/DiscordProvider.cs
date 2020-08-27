using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed
{
    internal class DiscordProvider
    {
        // Discord Provider
        [JsonProperty("name")]
        internal string Name { get; set; }

        // Discord Provider
        [JsonProperty("url")]
        internal string Url { get; set; }
    }
}