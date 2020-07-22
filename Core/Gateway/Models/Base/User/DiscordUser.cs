using FarDragi.DiscordCs.Core.Gateway.Models.Enums.User;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.User
{
    internal class DiscordUser
    {
        // Discord User
        [JsonProperty("id")]
        internal ulong Id { get; set; }

        // Discord User
        [JsonProperty("username")]
        internal string Username { get; set; }

        // Discord User
        [JsonProperty("discriminator")]
        internal string Discriminator { get; set; }

        // Discord User
        [JsonProperty("avatar")]
        internal string Avatar { get; set; }

        // Discord User
        [JsonProperty("bot")]
        internal bool IsBot { get; set; }

        // Discord User
        [JsonProperty("system")]
        internal bool IsSystem { get; set; }

        // Discord User
        [JsonProperty("mfa_enabled")]
        internal bool MfaEnabled { get; set; }

        // Discord User
        [JsonProperty("locale")]
        internal string Locale { get; set; }

        // Discord User
        [JsonProperty("verified")]
        internal bool IsVerified { get; set; }

        // Discord User
        [JsonProperty("email")]
        internal string Email { get; set; }

        // Discord User
        [JsonProperty("flags")]
        internal DiscordUserBadges Badges { get; set; }

        // Discord User
        [JsonProperty("premium_type")]
        internal DiscordUserPremiumType PremiumType { get; set; }

        // Discord User
        [JsonProperty("public_flags")]
        internal DiscordUserBadges PublicBadges { get; set; }
    }
}
