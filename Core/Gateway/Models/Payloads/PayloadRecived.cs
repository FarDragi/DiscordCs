using FarDragi.DragiCordApi.Core.Gateway.Codes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DragiCordApi.Core.Gateway.Models.Payloads
{
    class PayloadRecived
    {
        [JsonProperty("t")]
        public string Type { get; set; }
        [JsonProperty("op")]
        public GatewayOpcode Opcode { get; set; }
    }
}
