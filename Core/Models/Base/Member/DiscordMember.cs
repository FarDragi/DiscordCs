using FarDragi.DiscordCs.Core.Models.Base.User;
using System;

namespace FarDragi.DiscordCs.Core.Models.Base.Member
{
    public class DiscordMember
    {
        public DiscordUser User { get; set; }
        public string Nick { get; set; }
        public ulong[] Roles { get; set; }
        public DateTime JoinedAt { get; set; }
        public DateTime? PremiumSince { get; set; }
        public bool IsDeaf { get; set; }
        public bool IsMute { get; set; }
        public bool IsOwner { get; set; }
    }
}
