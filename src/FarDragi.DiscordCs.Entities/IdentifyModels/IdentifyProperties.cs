using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Entities.IdentifyModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#identify-identify-connection-properties
    /// </summary>
    public class IdentifyProperties
    {
        [JsonProperty("$os")]
        public string OS { get; set; }

        [JsonProperty("$browser")]
        public string Browser { get; set; }

        [JsonProperty("$device")]
        public string Device { get; set; }
    }
}
