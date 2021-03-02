using FarDragi.DiscordCs.Entity.Models.UserModels;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.TeamModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/teams#data-models-team-members-object
    /// </summary>
    public class TeamMember
    {
        [JsonPropertyName("membership_state")]
        public int MembershipState { get; set; }

        [JsonPropertyName("permissions")]
        public ulong[] Permissions { get; set; }

        [JsonPropertyName("team_id")]
        public ulong TeamId { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }
    }
}
