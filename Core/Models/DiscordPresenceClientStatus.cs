using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DragiCordApi.Core.Models
{
    public class DiscordPresenceClientStatus
    {
        [JsonProperty("desktop")]
        public string Desktop { get; set; }
        [JsonProperty("mobile")]
        public string Mobile { get; set; }
        [JsonProperty("web")]
        public string Web { get; set; }
    }
}
