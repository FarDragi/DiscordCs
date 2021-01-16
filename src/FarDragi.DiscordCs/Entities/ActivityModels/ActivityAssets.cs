using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-assets
    /// </summary>
    public class ActivityAssets
    {
        [JsonProperty("large_image")]
        public string LargeImage { get; set; }

        [JsonProperty("large_text")]
        public string LargeText { get; set; }

        [JsonProperty("small_image")]
        public string SmallImage { get; set; }

        [JsonProperty("small_text")]
        public string SmallText { get; set; }
    }
}
