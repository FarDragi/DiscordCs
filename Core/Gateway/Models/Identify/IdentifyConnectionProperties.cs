using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Identify
{
    internal sealed class IdentifyConnectionProperties
    {
        [JsonProperty("$os")]
        internal string OperatingSystem { get; set; }
        [JsonProperty("$browser")]
        internal string Browser { get; set; }
        [JsonProperty("$device")]
        internal string Device { get; set; }
    }
}
