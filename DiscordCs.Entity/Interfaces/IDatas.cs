using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Models.UserModels;

namespace FarDragi.DiscordCs.Entity.Interfaces
{
    public interface IDatas
    {
        public User User { get; }
        public GuildCollection Guilds { get; }
        public UserCollection Users { get; }
        public ChannelCollection Channels { get; }
    }
}
