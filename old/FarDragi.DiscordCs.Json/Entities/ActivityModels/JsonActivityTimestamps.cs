using FarDragi.DiscordCs.Json.Converters;
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
        [JsonConverter(typeof(UnixSpanConverter))]
        public TimeSpan? Start { get; set; }

        [JsonProperty("end")]
        [JsonConverter(typeof(UnixSpanConverter))]
        public TimeSpan? End { get; set; }
    }
}
