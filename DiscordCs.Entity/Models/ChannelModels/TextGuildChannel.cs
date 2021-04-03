using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Models.MessageModels;
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

        public Message UpdateMessage(ref Message message)
        {
            Messages.Caching(ref message, true);
            return message;
        }
    }
}
