using FarDragi.DiscordCs.Entity.Models.UserModels;
using System;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.MemberModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#guild-member-object-guild-member-structure
    /// </summary>
    public class Member
    {
        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("nick")]
        public string Nick { get; set; }

        [JsonPropertyName("roles")]
        public ulong[] Roles { get; set; }

        [JsonPropertyName("joined_at")]
        public DateTime JoinedAt { get; set; }

        [JsonPropertyName("premium_since")]
        public DateTime? PremiumSince { get; set; }

        [JsonPropertyName("deaf")]
        public bool IsDeaf { get; set; }

        [JsonPropertyName("mute")]
        public bool IsMute { get; set; }

        [JsonPropertyName("pending")]
        public bool IsPending { get; set; }

        [JsonPropertyName("permissions")]
        public ulong? Permissions { get; set; }
    }
}
