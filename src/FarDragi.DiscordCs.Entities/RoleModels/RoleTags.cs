using FarDragi.DiscordCs.Json.Entities.RoleModels;

namespace FarDragi.DiscordCs.Entities.RoleModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/permissions#role-object-role-tags-structure
    /// </summary>
    public class RoleTags
    {
        public ulong BotId { get; set; }
        public ulong IntegrationId { get; set; }
        public bool PremiumSubscriber { get; set; }

        public static implicit operator RoleTags(JsonRoleTags json)
        {
            return new RoleTags
            {
                BotId = json.BotId,
                IntegrationId = json.IntegrationId,
                PremiumSubscriber = json.PremiumSubscriber
            };
        }
    }
}
