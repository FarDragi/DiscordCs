using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Activity
{
    internal class DiscordActivitySecrets
    {
        [JsonProperty("join")]
        internal string Join { get; set; }

        [JsonProperty("spectate")]
        internal string Spectate { get; set; }

        [JsonProperty("match")]
        internal string Match { get; set; }
    }
}