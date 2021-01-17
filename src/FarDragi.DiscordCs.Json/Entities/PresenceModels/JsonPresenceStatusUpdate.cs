using FarDragi.DiscordCs.Json.Entities.ActivityModels;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Json.Entities.PresenceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#update-status-gateway-status-update-structure
    /// </summary>
    public class JsonPresenceStatusUpdate
    {
        [JsonProperty("since")]
        public int? Since { get; set; }

        [JsonProperty("activities")]
        public JsonActivity[] Activities { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("afk")]
        public bool Afk { get; set; }
    }
}
