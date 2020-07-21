using FarDragi.DiscordCs.Core.Gateway.Models.Enums.Role;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Role
{
    internal class DiscordRole
    {
        // Discord Role
        [JsonProperty("id")]
        public ulong Id { get; set; }

        // Discord Role
        [JsonProperty("name")]
        public string Name { get; set; }

        // Discord Role
        [JsonProperty("color")]
        public uint Color { get; set; }

        // Discord Role
        [JsonProperty("hoist")]
        public bool IsHoist { get; set; }

        // Discord Role
        [JsonProperty("position")]
        public uint Position { get; set; }

        // Discord Role
        [JsonProperty("permissions")]
        public DiscordRolePermissions Permissions { get; set; }

        // Discord Role
        [JsonProperty("managed")]
        public bool IsManaged { get; set; }

        // Discord Role
        [JsonProperty("mentionable")]
        public bool IsMentionable { get; set; }
    }
}
