using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DragiCordApi.Core.Models
{
    public class DiscordRole
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("color")]
        public uint Color { get; set; }
        [JsonProperty("hoist")]
        public bool IsHoist { get; set; }
        [JsonProperty("position")]
        public uint Position { get; set; }
        [JsonProperty("permissions")]
        public DiscordRolePermission Permissions { get; set; }
        [JsonProperty("managed")]
        public bool IsManaged { get; set; }
        [JsonProperty("mentionable")]
        public bool IsMentionable { get; set; }
    }
}
