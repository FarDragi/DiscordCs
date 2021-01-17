using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Json.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-timestamps
    /// </summary>
    public class JsonActivityTimestamps
    {
        [JsonProperty("start")]
        public DateTime? Start { get; set; }

        [JsonProperty("end")]
        public DateTime? End { get; set; }
    }
}
