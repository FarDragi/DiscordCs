using FarDragi.DiscordCs.Core.Identify;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Models.Identify
{
    public class IdentifyProperties : IIdentifyProperties
    {
        [JsonProperty("$os")]
        private string os;
        [JsonProperty("$browser")]
        private string browser;
        [JsonProperty("$device")]
        private string device;

        public string OS 
        { 
            get => os; 
            set => os = value; 
        }

        public string Browser 
        { 
            get => browser; 
            set => browser = value; 
        }

        public string Device 
        { 
            get => device; 
            set => device = value; 
        }
    }
}
