using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Json.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-structure
    /// </summary>
    public class JsonActivity
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("timestamps")]
        public JsonActivityTimestamps Timestamps { get; set; }

        [JsonProperty("application_id")]
        public ulong? ApplicationId { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("emoji")]
        public JsonActivityEmoji Emoji { get; set; }

        [JsonProperty("party")]
        public JsonActivityParty Party { get; set; }

        [JsonProperty("assets")]
        public JsonActivityAssets Assets { get; set; }

        [JsonProperty("secrets")]
        public JsonActivitySecrets Secrets { get; set; }

        [JsonProperty("instance")]
        public bool? Instance { get; set; }

        [JsonProperty("flags")]
        public int Flags { get; set; }
    }
}
