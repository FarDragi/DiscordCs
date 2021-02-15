using FarDragi.DiscordCs.Json.Entities.ActivityModels;
using System;

namespace FarDragi.DiscordCs.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-structure
    /// </summary>
    public class Activity
    {
        public string Name { get; set; }
        public ActivityTypes Type { get; set; }
        public string Url { get; set; }
        public long CreatedAt { get; set; }
        public ActivityTimestamps Timestamps { get; set; }
        public ulong? ApplicationId { get; set; }
        public string Details { get; set; }
        public string State { get; set; }
        public ActivityEmoji Emoji { get; set; }
        public ActivityParty Party { get; set; }
        public ActivityAssets Assets { get; set; }
        public ActivitySecrets Secrets { get; set; }
        public bool? Instance { get; set; }
        public ActivityFlags Flags { get; set; }

        public static implicit operator Activity(JsonActivity json)
        {
            if (json == null) return null;

            Activity activity = new Activity
            {
                ApplicationId = json.ApplicationId,
                CreatedAt = json.CreatedAt,
                Details = json.Details,
                Flags = (ActivityFlags)json.Flags,
                Instance = json.Instance,
                Name = json.Name,
                State = json.State,
                Type = (ActivityTypes)json.Type,
                Url = json.Url,
                Assets = json.Assets,
                Emoji = json.Emoji,
                Party = json.Party,
                Secrets = json.Secrets,
                Timestamps = json.Timestamps
            };

            return activity;
        }

        public static implicit operator JsonActivity(Activity activity)
        {
            if (activity == null) return null;

            return new JsonActivity
            {
                ApplicationId = activity.ApplicationId,
                Assets = activity.Assets,
                CreatedAt = activity.CreatedAt,
                Details = activity.Details,
                Emoji = activity.Emoji,
                Flags = (int)activity.Flags,
                Instance = activity.Instance,
                Name = activity.Name,
                Party = activity.Party,
                Secrets = activity.Secrets,
                State = activity.State,
                Timestamps = activity.Timestamps,
                Type = (int)activity.Type,
                Url = activity.Url
            };
        }
    }
}
