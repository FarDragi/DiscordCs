using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-assets
    /// </summary>
    public class ActivityAssets
    {
        [JsonPropertyName("large_image")]
        public string LargeImage { get; set; }

        [JsonPropertyName("large_text")]
        public string LargeText { get; set; }

        [JsonPropertyName("small_image")]
        public string SmallImage { get; set; }

        [JsonPropertyName("small_text")]
        public string SmallText { get; set; }
    }
}
