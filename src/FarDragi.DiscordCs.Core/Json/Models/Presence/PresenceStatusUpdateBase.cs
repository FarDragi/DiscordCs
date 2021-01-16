using FarDragi.DiscordCs.Core.Interfaces.Activity;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Json.Models.Presence
{
    public class PresenceStatusUpdateBase
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
