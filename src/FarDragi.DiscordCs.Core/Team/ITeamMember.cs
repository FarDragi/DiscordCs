using FarDragi.DiscordCs.Core.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Team
{
    public interface ITeamMember
    {
        public int MembershipState { get; set; }
        public ulong[] Permissions { get; set; }
        public ulong TeamId { get; set; }
        public IDiscordUser User { get; set; }
    }
}
