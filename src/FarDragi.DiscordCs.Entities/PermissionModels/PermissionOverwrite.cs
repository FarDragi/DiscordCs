using FarDragi.DiscordCs.Json.Entities.PermissionModels;

namespace FarDragi.DiscordCs.Entities.PermissionModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#overwrite-object-overwrite-structure
    /// </summary>
    public class PermissionOverwrite
    {
        public ulong Id { get; set; }
        public PermissionTypes Type { get; set; }
        public ulong Allow { get; set; }
        public ulong Deny { get; set; }

        public static implicit operator PermissionOverwrite(JsonPermissionOverwrite json)
        {
            return new PermissionOverwrite
            {
                Allow = json.Allow,
                Deny = json.Deny,
                Id = json.Id,
                Type = (PermissionTypes)json.Type
            };
        }
    }
}
