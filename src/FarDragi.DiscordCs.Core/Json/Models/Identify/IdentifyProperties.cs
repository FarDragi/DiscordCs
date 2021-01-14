using FarDragi.DiscordCs.Core.Interfaces.Identify;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Json.Models.Identify
{
    public class IdentifyProperties : IIdentifyProperties
    {
        [JsonProperty("$os")]
        public string OS { get; set; }

        [JsonProperty("$browser")]
        public string Browser { get; set; }

        [JsonProperty("$device")]
        public string Device { get; set; }
    }
}
