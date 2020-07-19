using FarDragi.DiscordCs.Core.Gateway.Models.Enumerators;
using FarDragi.DiscordCs.Core.Gateway.Models.Enumerators.Role;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base
{
    internal class DiscordChannelOverrites
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("allow")]
        public DiscordRolePermissions Allow { get; set; }

        [JsonProperty("deny")]
        public DiscordRolePermissions Deny { get; set; }
    }
}