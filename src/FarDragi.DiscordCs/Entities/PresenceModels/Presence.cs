using FarDragi.DiscordCs.Entities.ActivityModels;
using FarDragi.DiscordCs.Entities.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.PresenceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#presence-update-presence-update-event-fields
    /// </summary>
    public class Presence
    {
        public User User { get; set; }
        public ulong GuildId { get; set; }
        public string Status { get; set; }
        public Activity[] Activities { get; set; }
        public PresenceClientStatus ClientStatus { get; set; }
    }
}
