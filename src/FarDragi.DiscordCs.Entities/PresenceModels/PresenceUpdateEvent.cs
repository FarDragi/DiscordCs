using FarDragi.DiscordCs.Entities.ActivityModels;
using FarDragi.DiscordCs.Entities.UserModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.PresenceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#presence-update-presence-update-event-fields
    /// </summary>
    public class PresenceUpdateEvent
    {
        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("activities")]
        public Activity[] Activities { get; set; }

        [JsonProperty("client_status")]
        public PresenceClientStatus ClientStatus { get; set; }
    }
}
