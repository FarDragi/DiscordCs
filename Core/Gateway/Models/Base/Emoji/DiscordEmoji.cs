using FarDragi.DiscordCs.Core.Gateway.Models.Base.User;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Emoji
{
    internal class DiscordEmoji
    {
        [JsonProperty("id")]
        public ulong? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roles")]
        public ulong[] Roles { get; set; }

        [JsonProperty("user")]
        public DiscordUser User { get; set; }

        [JsonProperty("require_colons")]
        public bool RequireColons { get; set; }

        [JsonProperty("managed")]
        public bool IsManaged { get; set; }

        [JsonProperty("animated")]
        public bool IsAnimated { get; set; }

        [JsonProperty("available")]
        public bool IsAvailable { get; set; }
    }
}
