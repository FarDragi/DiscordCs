using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Models.MessageModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ChannelModels
{
    public class TextGuildChannel : GuildChannel
    {
        [JsonIgnore]
        public MessageCollection Messages { get; set; }

        [JsonPropertyName("last_message_id")]
        public ulong? LastMessageId { get; set; }

        [JsonPropertyName("topic")]
        public string Topic { get; set; }

        public Message CachingMessage(ref Message message)
        {
            Messages.Caching(ref message);
            return message;
        }
    }
}
