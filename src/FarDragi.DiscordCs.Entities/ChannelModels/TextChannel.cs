using FarDragi.DiscordCs.Json.Entities.ChannelModels;

namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    public class TextChannel : Channel
    {
        public string Topic { get; set; }
        public ulong? LastMessageId { get; set; }
        public int RateLimitPerUser { get; set; }

        public TextChannel()
        {
            Type = ChannelTypes.GuildText;
        }

        public static explicit operator TextChannel(JsonChannel json)
        {
            return new TextChannel
            {
                Id = json.Id,
                Name = json.Name,
                GuildId = json.GuildId,
                LastPinTimestamp = json.LastPinTimestamp,
                Nsfw = json.Nsfw,
                ParentId = json.ParentId,
                Position = json.Position,
                Type = (ChannelTypes)json.Type,
                LastMessageId = json.LastMessageId,
                RateLimitPerUser = json.RateLimitPerUser,
                Topic = json.Topic
            };
        }
    }
}
