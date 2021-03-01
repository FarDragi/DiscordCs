using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-secrets
    /// </summary>
    public class ActivitySecrets
    {
        [JsonPropertyName("join")]
        public string Join { get; set; }

        [JsonPropertyName("spectate")]
        public string Spectate { get; set; }

        [JsonPropertyName("match")]
        public string Match { get; set; }
    }
}