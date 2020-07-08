using Newtonsoft.Json;

namespace FarDragi.DragiCordApi.Core.Models
{
    public class DiscordUser
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("discriminator")]
        public string Discriminator { get; set; }
        [JsonProperty("avatar")]
        public string Avatar { get; set; }
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
        public DiscordUserFlag Flags { get; set; }
        [JsonProperty("premium_type")]
        public DiscordUserPremiumType PremiumType { get; set; }
        [JsonProperty("public_flags")]
        public DiscordUserFlag PublicFlags { get; set; }
    }
}
