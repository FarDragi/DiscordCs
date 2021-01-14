using FarDragi.DiscordCs.Core.Activity;
using FarDragi.DiscordCs.Core.Presence;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Models.Presence
{
    public class PresenceStatusUpdate
    {
        [JsonProperty("since")]
        public int? Since { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("afk")]
        public bool Afk { get; set; }
    }
}
