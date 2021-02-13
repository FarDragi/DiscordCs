using FarDragi.DiscordCs.Json.Entities.RoleModels;

namespace FarDragi.DiscordCs.Entities.RoleModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/permissions#role-object-role-structure
    /// </summary>
    public class Role
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public int Color { get; set; }
        public bool Hoist { get; set; }
        public int Position { get; set; }
        public ulong Permissions { get; set; }
        public bool Managed { get; set; }
        public bool Mentionable { get; set; }
        public RoleTags Tags { get; set; }

        public static implicit operator Role(JsonRole json)
        {
            return new Role
            {
                Color = json.Color,
                Hoist = json.Hoist,
                Id = json.Id,
                Managed = json.Managed,
                Mentionable = json.Mentionable,
                Name = json.Name,
                Permissions = json.Permissions,
                Position = json.Position
            };
        }
    }
}
