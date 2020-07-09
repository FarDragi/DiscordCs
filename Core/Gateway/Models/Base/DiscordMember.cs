using Newtonsoft.Json;
using System;

namespace FarDragi.DragiCordApi.Core.Gateway.Models.Base
{
    internal class DiscordMember
    {
        [JsonProperty("user")]
        public DiscordUser User { get; set; }

        [JsonProperty("nick")]
        public string Nick { get; set; }

        [JsonProperty("roles")]
        public ulong[] Roles { get; set; }

        [JsonProperty("joined_at")]
        public DateTime JoinedAt { get; set; }

        [JsonProperty("premium_since")]
        public DateTime? PremiumSince { get; set; }

        [JsonProperty("deaf")]
        public bool IsDeaf { get; set; }

        [JsonProperty("mute")]
        public bool IsMute { get; set; }
    }
}