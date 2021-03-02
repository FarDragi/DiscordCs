using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.PermissionModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#overwrite-object-overwrite-structure
    /// </summary>
    public class PermissionOverwrite
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("type")]
        public PermissionTypes Type { get; set; }

        [JsonPropertyName("allow")]
        public ulong Allow { get; set; }

        [JsonPropertyName("deny")]
        public ulong Deny { get; set; }
    }
}
