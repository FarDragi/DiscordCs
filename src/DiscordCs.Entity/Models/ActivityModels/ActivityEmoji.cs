using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-emoji
    /// </summary>
    public class ActivityEmoji
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        [JsonPropertyName("animated")]
        public bool IsAnimated { get; set; }
    }
}
