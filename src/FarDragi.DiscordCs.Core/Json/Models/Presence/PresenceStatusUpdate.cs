using FarDragi.DiscordCs.Core.Interfaces.Activity;
using FarDragi.DiscordCs.Core.Interfaces.Presence;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Json.Models.Presence
{
    public class PresenceStatusUpdate : IPresenceStatusUpdate
    {
        [JsonProperty("since")]
        public int Since { get; set; }

        [JsonIgnore]
        public IDiscordActivity Activities { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("afk")]
        public bool Afk { get; set; }
    }
}
