using FarDragi.DiscordCs.Core.Gateway.Models.Base.User;
using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Presence
{
    internal class DiscordPresence
    {
        [JsonProperty("user")]
        public DiscordUser User { get; set; }

        [JsonProperty("roles")]
        public ulong Roles { get; set; }

        [JsonProperty("game")]
        public DiscordActivity Game { get; set; }

        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("activities")]
        public DiscordActivity[] Activities { get; set; }

        [JsonProperty("client_status")]
        public DiscordClientStatus ClientStatus { get; set; }

        [JsonProperty("premium_since")]
        public DateTime? PremiumSince { get; set; }

        [JsonProperty("nick")]
        public string Nick { get; set; }
    }
}