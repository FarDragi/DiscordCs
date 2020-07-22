using FarDragi.DiscordCs.Core.Models.Enums.Channel;
using FarDragi.DiscordCs.Core.Models.Enums.Role;

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
