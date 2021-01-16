using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-secrets
    /// </summary>
    public class ActivitySecrets
    {
        [JsonProperty("join")]
        public string Join { get; set; }

        [JsonProperty("spectate")]
        public string Spectate { get; set; }

        [JsonProperty("match")]
        public string Match { get; set; }
    }
}
