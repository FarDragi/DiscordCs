using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.UserModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/user#user-object-user-structure
    /// </summary>
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
        public UserFlags Flags { get; set; }

        [JsonPropertyName("premium_type")]
        public UserPremiumTypes PremiumType { get; set; }

        [JsonPropertyName("public_flags")]
        public UserFlags PublicFlags { get; set; }
    }
}
