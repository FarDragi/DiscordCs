namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    public class GuildStore : Channel
    {
        public static explicit operator GuildStore(BaseChannel channel)
        {
            return new GuildStore
            {
                Id = channel.Id,
                Name = channel.Name,
                GuildId = channel.GuildId,
                LastPinTimestamp = channel.LastPinTimestamp,
                Nsfw = channel.Nsfw,
                ParentId = channel.ParentId,
                Position = channel.Position,
                Type = channel.Type,
            };
        }
    }
}
