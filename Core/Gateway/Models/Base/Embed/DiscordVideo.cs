using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed
{
    internal class DiscordVideo
    {
        [JsonProperty("url")]
        internal string Url { get; set; }

        [JsonProperty("height")]
        internal uint Height { get; set; }

        [JsonProperty("width")]
        internal uint Width { get; set; }
    }
}
