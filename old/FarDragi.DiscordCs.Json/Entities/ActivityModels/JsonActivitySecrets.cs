using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Json.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-secrets
    /// </summary>
    public class JsonActivitySecrets
    {
        [JsonProperty("join")]
        public string Join { get; set; }

        [JsonProperty("spectate")]
        public string Spectate { get; set; }

        [JsonProperty("match")]
        public string Match { get; set; }
    }
}
