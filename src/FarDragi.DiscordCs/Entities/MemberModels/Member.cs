using FarDragi.DiscordCs.Entities.UserModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.MemberModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#guild-member-object-guild-member-structure
    /// </summary>
    public class Member
    {
        [JsonProperty("user")]
        public User User { get; set; }

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
