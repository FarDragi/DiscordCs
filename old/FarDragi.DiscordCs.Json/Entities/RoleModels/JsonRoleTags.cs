using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Json.Entities.RoleModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/permissions#role-object-role-tags-structure
    /// </summary>
    public class JsonRoleTags
    {
        [JsonProperty("bot_id")]
        public ulong BotId { get; set; }

        [JsonProperty("integration_id")]
        public ulong IntegrationId { get; set; }

        [JsonProperty("premium_subscriber")]
        public bool PremiumSubscriber { get; set; }
    }
}
