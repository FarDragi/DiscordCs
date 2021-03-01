using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.IdentifyModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#identify-identify-connection-properties
    /// </summary>
    public class IdentifyProperties
    {
        [JsonPropertyName("$os")]
        public string OS { get; set; }

        [JsonPropertyName("$browser")]
        public string Browser { get; set; }

        [JsonPropertyName("$device")]
        public string Device { get; set; }
    }
}
