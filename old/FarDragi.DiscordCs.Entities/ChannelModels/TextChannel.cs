using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entities.MessageModels;
using FarDragi.DiscordCs.Rest;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-example-guild-text-channel
    /// </summary>
    public class TextChannel : Channel, ICacheInit
    {
        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("last_message_id")]
        public ulong? LastMessageId { get; set; }

        [JsonProperty("rate_limit_per_user")]
        public int RateLimitPerUser { get; set; }

        [JsonIgnore]
        public MessageCollection Messages { get; set; }

        public void InitCaching(ICacheConfig config, RestClient rest)
        {
            Messages = new MessageCollection(config.GetCache<Message>(), rest.GetApiClient("/channels/{0}/messages"), Id);
        }

        public static explicit operator TextChannel(BaseChannel channel)
        {
            return new TextChannel
            {
                Id = channel.Id,
                Name = channel.Name,
                GuildId = channel.GuildId,
                LastPinTimestamp = channel.LastPinTimestamp,
                Nsfw = channel.Nsfw,
                ParentId = channel.ParentId,
                Position = channel.Position,
                Type = channel.Type,
                LastMessageId = channel.LastMessageId,
                RateLimitPerUser = channel.RateLimitPerUser,
                Topic = channel.Topic
            };
        }
    }
}
