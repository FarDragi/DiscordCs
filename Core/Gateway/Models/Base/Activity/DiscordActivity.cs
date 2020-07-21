using FarDragi.DiscordCs.Core.Gateway.Models.Base.Emoji;
using FarDragi.DiscordCs.Core.Gateway.Models.Enums;
using FarDragi.DiscordCs.Core.Gateway.Models.Enums.Activity;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Activity
{
    internal class DiscordActivity
    {
        [JsonProperty("name")]
        internal string Name { get; set; }

        [JsonProperty("type")]
        internal DiscordActivityType Type { get; set; }

        [JsonProperty("url")]
        internal string Url { get; set; }

        [JsonProperty("created_at")]
        internal ulong CreatedAt { get; set; }

        [JsonProperty("timestamps")]
        internal DiscordActivityTimestamp Timestamps { get; set; }

        [JsonProperty("application_id")]
        internal ulong ApplicationId { get; set; }

        [JsonProperty("details")]
        internal string Details { get; set; }

        [JsonProperty("state")]
        internal string State { get; set; }

        [JsonProperty("emoji")]
        internal DiscordEmoji Emoji { get; set; }

        [JsonProperty("party")]
        internal DiscordActivityParty Party { get; set; }

        [JsonProperty("assets")]
        internal DiscordActivityAssets Assets { get; set; }

        [JsonProperty("secrets")]
        internal DiscordActivitySecrets Secrets { get; set; }

        [JsonProperty("instance")]
        internal bool IsInstance { get; set; }

        [JsonProperty("flags")]
        internal DiscordActivityFlags Flags { get; set; }
    }
}