using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.PresenceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#client-status-object
    /// </summary>
    public class PresenceClientStatus
    {
        [JsonPropertyName("desktop")]
        public string Desktop { get; set; }

        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        [JsonPropertyName("web")]
        public string Web { get; set; }
    }
}
