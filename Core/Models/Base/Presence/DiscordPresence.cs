using FarDragi.DiscordCs.Core.Models.Base.Activity;
using FarDragi.DiscordCs.Core.Models.Base.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Base.Presence
{
    public class DiscordPresence
    {
        public DiscordUser User { get; set; }
        public ulong Roles { get; set; }
        public DiscordActivity Game { get; set; }
        public ulong GuildId { get; set; }
        public string Status { get; set; }
        public DiscordActivity[] Activities { get; set; }
        public DiscordClientStatus ClientStatus { get; set; }
        public DateTime? PremiumSince { get; set; }
        public string Nick { get; set; }
    }
}
