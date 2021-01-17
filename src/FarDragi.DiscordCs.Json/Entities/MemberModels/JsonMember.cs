using FarDragi.DiscordCs.Json.Entities.UserModels;
using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Json.Entities.MemberModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#guild-member-object-guild-member-structure
    /// </summary>
    public class JsonMember
    {
        [JsonProperty("user")]
        public JsonUser User { get; set; }

        [JsonProperty("nick")]
        public string Nick { get; set; }

        [JsonProperty("roles")]
        public ulong[] Roles { get; set; }

        [JsonProperty("joined_at")]
        public DateTime JoinedAt { get; set; }

        [JsonProperty("premium_since")]
        public DateTime? PremiumSince { get; set; }

        [JsonProperty("deaf")]
        public bool Deaf { get; set; }

        [JsonProperty("mute")]
        public bool Mute { get; set; }

        [JsonProperty("pending")]
        public bool Pending { get; set; }
    }
}
