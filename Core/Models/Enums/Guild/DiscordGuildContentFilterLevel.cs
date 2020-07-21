using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Enums.Guild
{
    public enum DiscordGuildContentFilterLevel : byte
    {
        Disable = 0,
        MembersWithoutRoles = 1,
        AllMembers = 2
    }
}
