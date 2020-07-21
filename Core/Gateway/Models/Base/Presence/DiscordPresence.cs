using FarDragi.DiscordCs.Core.Gateway.Models.Base.Activity;
using FarDragi.DiscordCs.Core.Gateway.Models.Base.User;
using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Presence
{
    internal class DiscordPresence
    {
        [JsonProperty("user")]
        internal DiscordUser User { get; set; }

        [JsonProperty("roles")]
        internal ulong Roles { get; set; }

        [JsonProperty("game")]
        internal DiscordActivity Game { get; set; }

        [JsonProperty("guild_id")]
        internal ulong GuildId { get; set; }

        [JsonProperty("status")]
        internal string Status { get; set; }

        [JsonProperty("activities")]
        internal DiscordActivity[] Activities { get; set; }

        [JsonProperty("client_status")]
        internal DiscordClientStatus ClientStatus { get; set; }

        [JsonProperty("premium_since")]
        internal DateTime? PremiumSince { get; set; }

        [JsonProperty("nick")]
        internal string Nick { get; set; }
    }
}