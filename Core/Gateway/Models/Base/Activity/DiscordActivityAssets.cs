using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Activity
{
    internal class DiscordActivityAssets
    {
        [JsonProperty("large_image")]
        internal string LargeImage { get; set; }

        [JsonProperty("large_text")]
        internal string LargeText { get; set; }

        [JsonProperty("small_image")]
        internal string SmallImage { get; set; }

        [JsonProperty("small_text")]
        internal string SmallText { get; set; }
    }
}