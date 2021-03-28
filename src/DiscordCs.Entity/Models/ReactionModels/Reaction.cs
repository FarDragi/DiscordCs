using FarDragi.DiscordCs.Entity.Models.EmojiModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ReactionModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#reaction-object-reaction-structure
    /// </summary>
    public class Reaction
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("me")]
        public bool Me { get; set; }

        [JsonPropertyName("emoji")]
        public Emoji Emoji { get; set; }
    }
}
