using FarDragi.DiscordCs.Json.Entities.UserModels;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Entities.UserModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/user#user-object-user-structure
    /// </summary>
    public class User
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("discriminator")]
        public string Discriminator { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("bot")]
        public bool IsBot { get; set; }

        [JsonProperty("system")]
        public bool IsSystem { get; set; }

        [JsonProperty("mfa_enabled")]
        public bool IsMfaEnabled { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("flags")]
        public UserFlags Flags { get; set; }

        [JsonProperty("premium_type")]
        public UserPremiumTypes PremiumType { get; set; }

        [JsonProperty("public_flags")]
        public UserFlags PublicFlags { get; set; }
    }
}
