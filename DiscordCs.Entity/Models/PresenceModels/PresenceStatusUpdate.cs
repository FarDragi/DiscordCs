using FarDragi.DiscordCs.Entity.Models.ActivityModels;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.PresenceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#update-status-gateway-status-update-structure
    /// </summary>
    public class PresenceStatusUpdate
    {
        [JsonPropertyName("since")]
        public int? Since { get; set; }

        [JsonPropertyName("activities")]
        public Activity[] Activities { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("afk")]
        public bool IsAfk { get; set; }
    }
}
