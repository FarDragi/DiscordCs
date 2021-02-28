using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Json.Entities.PresenceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#client-status-object
    /// </summary>
    public class JsonPresenceClientStatus
    {
        [JsonProperty("desktop")]
        public string Desktop { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("web")]
        public string Web { get; set; }
    }
}
