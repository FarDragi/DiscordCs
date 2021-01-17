using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Json.Entities.PermissionModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#overwrite-object-overwrite-structure
    /// </summary>
    public class JsonPermissionOverwrite
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("allow")]
        public ulong Allow { get; set; }

        [JsonProperty("deny")]
        public ulong Deny { get; set; }
    }
}
