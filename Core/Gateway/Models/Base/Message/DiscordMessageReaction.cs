using FarDragi.DiscordCs.Core.Gateway.Models.Base.Emoji;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Message
{
    internal class DiscordMessageReaction
    {
        [JsonProperty("count")]
        internal uint Count { get; set; }

        [JsonProperty("me")]
        internal bool IsMe { get; set; }

        [JsonProperty("emoji")]
        internal DiscordEmoji Emoji { get; set; }
    }
}
