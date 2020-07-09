using Newtonsoft.Json;

namespace FarDragi.DragiCordApi.Core.Gateway.Models.Base
{
    public class DiscordClientStatus
    {
        [JsonProperty("desktop")]
        public string Desktop { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("web")]
        public string Web { get; set; }
    }
}
