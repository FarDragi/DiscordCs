using FarDragi.DiscordCs.Json.Entities.ActivityModels;
using System;

namespace FarDragi.DiscordCs.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-timestamps
    /// </summary>
    public class ActivityTimestamps
    {
        public TimeSpan? Start { get; set; }
        public TimeSpan? End { get; set; }

        public static implicit operator ActivityTimestamps(JsonActivityTimestamps json)
        {
            if (json == null) return null;

            return new ActivityTimestamps
            {
                End = json.End,
                Start = json.Start
            };
        }

        public static implicit operator JsonActivityTimestamps(ActivityTimestamps activityTimestamps)
        {
            if (activityTimestamps == null) return null;

            return new JsonActivityTimestamps
            {
                End = activityTimestamps.End,
                Start = activityTimestamps.Start
            };
        }
    }
}
