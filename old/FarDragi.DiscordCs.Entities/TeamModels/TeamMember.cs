using FarDragi.DiscordCs.Entities.UserModels;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Entities.TeamModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/teams#data-models-team-members-object
    /// </summary>
    public class TeamMember
    {
        [JsonProperty("membership_state")]
        public int MembershipState { get; set; }

        [JsonProperty("permissions")]
        public ulong[] Permissions { get; set; }

        [JsonProperty("team_id")]
        public ulong TeamId { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}
