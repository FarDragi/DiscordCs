using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed
{
    internal class DiscordVideo
    {
        // Discord Video
        [JsonProperty("url")]
        internal string Url { get; set; }

        // Discord Video
        [JsonProperty("height")]
        internal uint Height { get; set; }

        // Discord Video
        [JsonProperty("width")]
        internal uint Width { get; set; }
    }
}
