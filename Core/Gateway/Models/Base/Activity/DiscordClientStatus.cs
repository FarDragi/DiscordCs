using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Activity
{
    internal class DiscordClientStatus
    {
        [JsonProperty("desktop")]
        internal string Desktop { get; set; }

        [JsonProperty("mobile")]
        internal string Mobile { get; set; }

        [JsonProperty("web")]
        internal string Web { get; set; }
    }
}
