using FarDragi.DiscordCs.Entities.UserModels;
using FarDragi.DiscordCs.Json.Entities.MemberModels;
using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Entities.MemberModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#guild-member-object-guild-member-structure
    /// </summary>
    public class Member
    {
        public User User { get; set; }
        public string Nick { get; set; }
        public ulong[] Roles { get; set; }
        public DateTime JoinedAt { get; set; }
        public DateTime? PremiumSince { get; set; }
        public bool IsDeaf { get; set; }
        public bool IsMute { get; set; }
        public bool IsPending { get; set; }
        public ulong? Permissions { get; set; }

        public static implicit operator Member(JsonMember json)
        {
            return new Member
            {
                IsDeaf = json.IsDeaf,
                JoinedAt = json.JoinedAt,
                IsMute = json.IsMute,
                Nick = json.Nick,
                IsPending = json.IsPending,
                Permissions = json.Permissions,
                PremiumSince = json.PremiumSince,
                Roles = json.Roles,
            };
        }
    }
}
