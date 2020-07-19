using FarDragi.DiscordCs.Core.Models.Enumerators.Role;

namespace FarDragi.DiscordCs.Core.Models.Base.Role
{
    public class DiscordRole
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public uint Color { get; set; }
        public bool IsHoist { get; set; }
        public uint Position { get; set; }
        public DiscordRolePermissions Permissions { get; set; }
        public bool IsManaged { get; set; }
        public bool IsMentionable { get; set; }
    }
}
