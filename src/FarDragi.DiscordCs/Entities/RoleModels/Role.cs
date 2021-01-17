using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.RoleModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/permissions#role-object-role-structure
    /// </summary>
    public class Role
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("hoist")]
        public bool Hoist { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("permissions")]
        public ulong Permissions { get; set; }

        [JsonProperty("managed")]
        public bool Managed { get; set; }

        [JsonProperty("mentionable")]
        public bool Mentionable { get; set; }

        [JsonProperty("tags")]
        public RoleTags Tags { get; set; }
    }
}
