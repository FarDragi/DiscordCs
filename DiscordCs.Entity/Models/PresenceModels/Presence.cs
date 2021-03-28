using FarDragi.DiscordCs.Entity.Models.ActivityModels;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.PresenceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#presence-update-presence-update-event-fields
    /// </summary>
    public class Presence
    {
        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("guild_id")]
        public ulong GuildId { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("activities")]
        public Activity[] Activities { get; set; }

        [JsonPropertyName("client_status")]
        public PresenceClientStatus ClientStatus { get; set; }
    }
}
