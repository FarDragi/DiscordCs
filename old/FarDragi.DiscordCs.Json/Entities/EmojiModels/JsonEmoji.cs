using FarDragi.DiscordCs.Json.Entities.UserModels;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Json.Entities.EmojiModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/emoji#emoji-object-emoji-structure
    /// </summary>
    public class JsonEmoji
    {
        [JsonProperty("id")]
        public ulong? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("user")]
        public JsonUser User { get; set; }

        [JsonProperty("require_colons")]
        public bool RequireColons { get; set; }

        [JsonProperty("managed")]
        public bool Managed { get; set; }

        [JsonProperty("animated")]
        public bool Animated { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }
    }
}
