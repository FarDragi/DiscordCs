using FarDragi.DiscordCs.Core.Gateway.Models.Enumerators;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base
{
    internal class DiscordUser
    {
        // Discord User
        [JsonProperty("id")]
        public ulong Id { get; set; }

        // Discord User
        [JsonProperty("username")]
        public string Username { get; set; }

        // Discord User
        [JsonProperty("discriminator")]
        public string Discriminator { get; set; }

        // Discord User
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        // Discord User
        [JsonProperty("bot")]
        public bool IsBot { get; set; }

        [JsonProperty("system")]
        public bool IsSystem { get; set; }

        [JsonProperty("mfa_enabled")]
        public bool MfaEnabled { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("flags")]
        public DiscordBadges Badges { get; set; }

        [JsonProperty("premium_type")]
        public DiscordPremiumType PremiumType { get; set; }

        [JsonProperty("public_flags")]
        public DiscordBadges PublicBadges { get; set; }
    }
}
