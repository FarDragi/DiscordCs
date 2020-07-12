using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base
{
    internal class DiscordClientStatus
    {
        [JsonProperty("desktop")]
        public string Desktop { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("web")]
        public string Web { get; set; }
    }
}
