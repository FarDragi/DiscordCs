using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.TeamModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/teams#data-models-team-object
    /// </summary>
    public class Team
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("members")]
        public TeamMember[] Members { get; set; }

        [JsonProperty("owner_user_id")]
        public ulong OwnerUserId { get; set; }
    }
}
