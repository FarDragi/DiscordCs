using FarDragi.DiscordCs.Entity.Models.UserModels;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.EmojiModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/emoji#emoji-object-emoji-structure
    /// </summary>
    public class Emoji
    {
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("roles")]
        public string[] Roles { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("require_colons")]
        public bool IsRequireColons { get; set; }

        [JsonPropertyName("managed")]
        public bool IsManaged { get; set; }

        [JsonPropertyName("animated")]
        public bool IsAnimated { get; set; }

        [JsonPropertyName("available")]
        public bool IsAvailable { get; set; }
    }
}
