using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-example-guild-text-channel
    /// </summary>
    public class TextChannel : TextGuildChannel
    {
        [JsonPropertyName("rate_limit_per_user")]
        public int? RateLimitPerUser { get; set; }
    }
}
