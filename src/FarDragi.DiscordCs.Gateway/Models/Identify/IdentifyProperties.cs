using FarDragi.DiscordCs.Core.Identify;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Models.Identify
{
    public class IdentifyProperties
    {
        [JsonProperty("$os")]
        public string os;
        [JsonProperty("$browser")]
        public string browser;
        [JsonProperty("$device")]
        public string device;
    }
}
