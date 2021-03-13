using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.TeamModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/teams#data-models-team-object
    /// </summary>
    public class Team
    {
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("members")]
        public TeamMember[] Members { get; set; }

        [JsonPropertyName("owner_user_id")]
        public ulong OwnerUserId { get; set; }
    }
}
