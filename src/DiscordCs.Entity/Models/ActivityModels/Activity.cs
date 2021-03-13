using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-structure
    /// </summary>
    public class Activity
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public ActivityTypes Type { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("created_at")]
        public long CreatedAt { get; set; }

        [JsonPropertyName("timestamps")]
        public ActivityTimestamps Timestamps { get; set; }

        [JsonPropertyName("application_id")]
        public ulong? ApplicationId { get; set; }

        [JsonPropertyName("details")]
        public string Details { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("emoji")]
        public ActivityEmoji Emoji { get; set; }

        [JsonPropertyName("party")]
        public ActivityParty Party { get; set; }

        [JsonPropertyName("assets")]
        public ActivityAssets Assets { get; set; }

        [JsonPropertyName("secrets")]
        public ActivitySecrets Secrets { get; set; }

        [JsonPropertyName("instance")]
        public bool? IsInstance { get; set; }

        [JsonPropertyName("flags")]
        public ActivityFlags Flags { get; set; }
    }
}
