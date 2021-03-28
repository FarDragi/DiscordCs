using System;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-timestamps
    /// </summary>
    public class ActivityTimestamps
    {
        [JsonPropertyName("start")]
        public TimeSpan? Start { get; set; }

        [JsonPropertyName("end")]
        public TimeSpan? End { get; set; }
    }
}
