using FarDragi.DiscordCs.Core.Gateway.Models.Base.User;
using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Member
{
    internal class DiscordMember
    {
        // Discord Member
        [JsonProperty("user")]
        internal DiscordUser User { get; set; }

        // Discord Member
        [JsonProperty("nick")]
        internal string Nick { get; set; }

        // Discord Member
        [JsonProperty("roles")]
        internal ulong[] Roles { get; set; }

        // Discord Member
        [JsonProperty("joined_at")]
        internal DateTime JoinedAt { get; set; }

        // Discord Member
        [JsonProperty("premium_since")]
        internal DateTime? PremiumSince { get; set; }

        // Discord Member
        [JsonProperty("deaf")]
        internal bool IsDeaf { get; set; }

        // Discord Member
        [JsonProperty("mute")]
        internal bool IsMute { get; set; }
    }
}