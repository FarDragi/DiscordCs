using Newtonsoft.Json;

namespace FarDragi.DragiCordApi.Core.Models
{
    public class DiscordChannelOverrites
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("allow")]
        public DiscordRolePermission Allow { get; set; }
        [JsonProperty("deny")]
        public DiscordRolePermission Deny { get; set; }
    }
}