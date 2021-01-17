using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Json.Entities.TeamModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/teams#data-models-team-object
    /// </summary>
    public class JsonTeam
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("members")]
        public JsonTeamMember[] Members { get; set; }

        [JsonProperty("owner_user_id")]
        public ulong OwnerUserId { get; set; }
    }
}
