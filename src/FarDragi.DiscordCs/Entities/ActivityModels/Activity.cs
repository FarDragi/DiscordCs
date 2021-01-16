using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-structure
    /// </summary>
    public class Activity
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public ActivityType Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("timestamps")]
        public ActivityTimestamps Timestamps { get; set; }

        [JsonProperty("application_id")]
        public ulong? ApplicationId { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("emoji")]
        public ActivityEmoji Emoji { get; set; }

        [JsonProperty("party")]
        public ActivityParty Party { get; set; }

        [JsonProperty("assets")]
        public ActivityAssets Assets { get; set; }

        [JsonProperty("secrets")]
        public ActivitySecrets Secrets { get; set; }

        [JsonProperty("instance")]
        public bool? Instance { get; set; }

        [JsonProperty("flags")]
        public ActivityFlag Flags { get; set; }
    }
}
