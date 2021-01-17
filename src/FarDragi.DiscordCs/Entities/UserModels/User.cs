using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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
        public bool Bot { get; set; }

        [JsonProperty("system")]
        public bool System { get; set; }

        [JsonProperty("mfa_enabled")]
        public bool MfaEnabled { get; set; }

        [JsonProperty("locale")]
        public bool Locale { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

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
