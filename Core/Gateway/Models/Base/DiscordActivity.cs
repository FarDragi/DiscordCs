using FarDragi.DiscordCs.Core.Gateway.Models.Enumerators;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base
{
    internal class DiscordActivity
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public DiscordActivityType Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("created_at")]
        public ulong CreatedAt { get; set; }

        [JsonProperty("timestamps")]
        public DiscordActivityTimestamp Timestamps { get; set; }

        [JsonProperty("application_id")]
        public ulong ApplicationId { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("emoji")]
        public DiscordEmoji Emoji { get; set; }

        [JsonProperty("party")]
        public DiscordActivityParty Party { get; set; }

        [JsonProperty("assets")]
        public DiscordActivityAssets Assets { get; set; }

        [JsonProperty("secrets")]
        public DiscordActivitySecrets Secrets { get; set; }

        [JsonProperty("instance")]
        public bool IsInstance { get; set; }

        [JsonProperty("flags")]
        public DiscordActivityFlags Flags { get; set; }
    }
}