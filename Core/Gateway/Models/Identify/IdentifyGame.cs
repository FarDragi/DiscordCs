using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Identify
{
    internal sealed class IdentifyGame
    {
        [JsonProperty("name")]
        internal string Name { get; set; }
        [JsonProperty("type")]
        internal byte Type { get; set; }
    }
}
