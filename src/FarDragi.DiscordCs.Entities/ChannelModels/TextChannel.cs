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
