using FarDragi.DiscordCs.Entities.ActivityModels;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Entities.PresenceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#update-status-gateway-status-update-structure
    /// </summary>
    public class PresenceStatusUpdate
    {
        [JsonProperty("since")]
        public int? Since { get; set; }

        [JsonProperty("activities")]
        public Activity[] Activities { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("afk")]
        public bool Afk { get; set; }
    }
}
