using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Models.MessageModels;
using FarDragi.DiscordCs.Entity.Models.PermissionModels;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-example-guild-text-channel
    /// </summary>
    public class TextChannel : Channel
    {
        [JsonIgnore]
        public MessageCollection Messages { get; set; }

        [JsonPropertyName("last_message_id")]
        public ulong? LastMessageId { get; set; }

        [JsonPropertyName("topic")]
        public string Topic { get; set; }

        [JsonPropertyName("rate_limit_per_user")]
        public int? RateLimitPerUser { get; set; }

        [JsonPropertyName("recipients")]
        public UserCollection Recipients { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("owner_id")]
        public ulong OwnerId { get; set; }

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
