using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Entities.PermissionModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#overwrite-object-overwrite-structure
    /// </summary>
    public class PermissionOverwrite
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("type")]
        public PermissionTypes Type { get; set; }

        [JsonProperty("allow")]
        public ulong Allow { get; set; }

        [JsonProperty("deny")]
        public ulong Deny { get; set; }
    }
}
