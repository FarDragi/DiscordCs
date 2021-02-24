namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    public class GuildNews : Channel
    {
        public string Topic { get; set; }
        public ulong? LastMessageId { get; set; }

        public GuildNews()
        {
            Type = ChannelTypes.GuildNews;
        }

        public static explicit operator GuildNews(BaseChannel channel)
        {
            return new GuildNews
            {
                Id = channel.Id,
                Name = channel.Name,
                GuildId = channel.GuildId,
                LastPinTimestamp = channel.LastPinTimestamp,
                Nsfw = channel.Nsfw,
                ParentId = channel.ParentId,
                Position = channel.Position,
                Type = channel.Type,
                Topic = channel.Topic,
                LastMessageId = channel.LastMessageId
            };
        }
    }
}
