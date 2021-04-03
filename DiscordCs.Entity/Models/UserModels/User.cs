using System.Diagnostics;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.UserModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/user#user-object-user-structure
    /// </summary>
    [DebuggerDisplay("({Id, nq}) {UserName, nq}#{Discriminator, nq}")]
    public class User
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("username")]
        public string UserName { get; set; }

        [JsonPropertyName("discriminator")]
        public string Discriminator { get; set; }

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }

        [JsonPropertyName("bot")]
        public bool IsBot { get; set; }

        [JsonPropertyName("system")]
        public bool IsSystem { get; set; }

        [JsonPropertyName("mfa_enabled")]
        public bool IsMfaEnabled { get; set; }

        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        [JsonPropertyName("verified")]
        public bool IsVerified { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("flags")]
        public UserBadges Badges { get; set; }

        [JsonPropertyName("premium_type")]
        public UserPremiumTypes PremiumType { get; set; }

        [JsonPropertyName("public_flags")]
        public UserBadges PublicBadges { get; set; }
    }
}
