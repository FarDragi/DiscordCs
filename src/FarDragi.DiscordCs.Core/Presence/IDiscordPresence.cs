using FarDragi.DiscordCs.Core.Activity;
using FarDragi.DiscordCs.Core.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Presence
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#presence-update-presence-update-event-fields
    /// </summary>
    public interface IDiscordPresence
    {
        public IDiscordUser User { get; set; }
        public ulong GuildId { get; set; }
        public string Status { get; set; }
        public IDiscordActivity[] Activities { get; set; }
        public IPresenceClientStatus ClientStatus { get; set; }
    }
}
