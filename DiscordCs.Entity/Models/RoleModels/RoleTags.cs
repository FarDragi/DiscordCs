using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.RoleModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/permissions#role-object-role-tags-structure
    /// </summary>
    public class RoleTags
    {
        [JsonPropertyName("bot_id")]
        public ulong BotId { get; set; }

        [JsonPropertyName("integration_id")]
        public ulong IntegrationId { get; set; }

        //[JsonProperty("premium_subscriber")]
        //public bool PremiumSubscriber { get; set; }
    }
}
