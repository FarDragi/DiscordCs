using FarDragi.DiscordCs.Entities.EmojiModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.MessageModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#reaction-object-reaction-structure
    /// </summary>
    public class MessageReaction
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("me")]
        public bool IsMe { get; set; }

        [JsonProperty("emoji")]
        public Emoji Emoji { get; set; }
    }
}
