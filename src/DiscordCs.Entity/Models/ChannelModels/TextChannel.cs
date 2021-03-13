using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-example-guild-text-channel
    /// </summary>
    public class TextChannel : GuildChannel
    {
        [JsonPropertyName("rate_limit_per_user")]
        public int? RateLimitPerUser { get; set; }

        [JsonPropertyName("topic")]
        public string Topic { get; set; }

        [JsonPropertyName("last_message_id")]
        public ulong? LastMessageId { get; set; }
    }
}
