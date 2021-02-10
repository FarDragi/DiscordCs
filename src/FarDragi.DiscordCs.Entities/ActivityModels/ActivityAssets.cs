using FarDragi.DiscordCs.Json.Entities.ActivityModels;

namespace FarDragi.DiscordCs.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-assets
    /// </summary>
    public class ActivityAssets
    {
        public string LargeImage { get; set; }
        public string LargeText { get; set; }
        public string SmallImage { get; set; }
        public string SmallText { get; set; }

        public static implicit operator JsonActivityAssets(ActivityAssets activityAssets)
        {
            return new JsonActivityAssets
            {
                LargeImage = activityAssets.LargeImage,
                LargeText = activityAssets.LargeText,
                SmallImage = activityAssets.SmallImage,
                SmallText = activityAssets.SmallText
            };
        }
    }
}
