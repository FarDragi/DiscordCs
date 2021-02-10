using FarDragi.DiscordCs.Json.Entities.ActivityModels;
using System;

namespace FarDragi.DiscordCs.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-timestamps
    /// </summary>
    public class ActivityTimestamps
    {
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }

        public static implicit operator JsonActivityTimestamps(ActivityTimestamps activityTimestamps)
        {
            return new JsonActivityTimestamps
            {
                End = activityTimestamps.End,
                Start = activityTimestamps.Start
            };
        }
    }
}
