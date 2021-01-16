using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-emoji
    /// </summary>
    public class ActivityEmoji
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public ulong? Id { get; set; }

        [JsonProperty("animated")]
        public bool Animated { get; set; }
    }
}
