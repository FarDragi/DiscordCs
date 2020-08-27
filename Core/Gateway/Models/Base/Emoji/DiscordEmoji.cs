using FarDragi.DiscordCs.Core.Gateway.Models.Base.User;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Emoji
{
    internal class DiscordEmoji
    {
        [JsonProperty("id")]
        internal ulong? Id { get; set; }

        [JsonProperty("name")]
        internal string Name { get; set; }

        [JsonProperty("roles")]
        internal ulong[] Roles { get; set; }

        [JsonProperty("user")]
        internal DiscordUser User { get; set; }

        [JsonProperty("require_colons")]
        internal bool RequireColons { get; set; }

        [JsonProperty("managed")]
        internal bool IsManaged { get; set; }

        [JsonProperty("animated")]
        internal bool IsAnimated { get; set; }

        [JsonProperty("available")]
        internal bool IsAvailable { get; set; }
    }
}
