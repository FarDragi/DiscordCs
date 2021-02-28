using FarDragi.DiscordCs.Json.Entities.ActivityModels;
using FarDragi.DiscordCs.Json.Entities.UserModels;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Json.Entities.PresenceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#presence-update-presence-update-event-fields
    /// </summary>
    public class JsonPresence
    {
        [JsonProperty("user")]
        public JsonUser User { get; set; }

        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("activities")]
        public JsonActivity[] Activities { get; set; }

        [JsonProperty("client_status")]
        public JsonPresenceClientStatus ClientStatus { get; set; }
    }
}
