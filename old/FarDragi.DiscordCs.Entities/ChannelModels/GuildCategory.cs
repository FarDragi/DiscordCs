namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    public class GuildCategory : Channel
    {
        public GuildCategory()
        {
            Type = ChannelTypes.GuildCategory;
        }

        public static explicit operator GuildCategory(BaseChannel channel)
        {
            return new GuildCategory
            {
                Id = channel.Id,
                Name = channel.Name,
                GuildId = channel.GuildId,
                LastPinTimestamp = channel.LastPinTimestamp,
                Nsfw = channel.Nsfw,
                ParentId = channel.ParentId,
                Position = channel.Position,
                Type = channel.Type
            };
        }
    }
}
