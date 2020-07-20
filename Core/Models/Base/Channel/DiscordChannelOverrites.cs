using FarDragi.DiscordCs.Core.Models.Enumerators.Channel;
using FarDragi.DiscordCs.Core.Models.Enumerators.Role;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Base.Channel
{
    public class DiscordChannelOverrites
    {
        public ulong Id { get; set; }
        public DiscordChannelOverritesType Type { get; set; }
        public DiscordRolePermissions Allow { get; set; }
        public DiscordRolePermissions Deny { get; set; }
    }
}
