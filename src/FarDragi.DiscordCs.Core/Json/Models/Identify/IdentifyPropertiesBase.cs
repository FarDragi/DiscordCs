using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Json.Models.Identify
{
    public class IdentifyPropertiesBase
    {
        [JsonProperty("$os")]
        public string OS { get; set; }

        [JsonProperty("$browser")]
        public string Browser { get; set; }

        [JsonProperty("$device")]
        public string Device { get; set; }
    }
}
