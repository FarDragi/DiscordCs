using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.RoleModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/permissions#role-object-role-structure
    /// </summary>
    public class Role
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("color")]
        public int Color { get; set; }

        [JsonPropertyName("hoist")]
        public bool IsHoist { get; set; }

        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("permissions")]
        public ulong Permissions { get; set; }

        [JsonPropertyName("managed")]
        public bool IsManaged { get; set; }

        [JsonPropertyName("mentionable")]
        public bool IsMentionable { get; set; }

        [JsonPropertyName("tags")]
        public RoleTags Tags { get; set; }
    }
}
