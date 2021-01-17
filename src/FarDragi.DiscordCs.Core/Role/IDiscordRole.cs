namespace FarDragi.DiscordCs.Core.Role
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/permissions#role-object-role-structure
    /// </summary>
    public interface IDiscordRole
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public int Color { get; set; }
        public bool Hoist { get; set; }
        public int Position { get; set; }
        public ulong Permissions { get; set; }
        public bool Managed { get; set; }
        public bool Mentionable { get; set; }
        public IRoleTags Tags { get; set; }
    }
}
