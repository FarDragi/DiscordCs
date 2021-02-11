using FarDragi.DiscordCs.Entities.GuildModels;
using FarDragi.DiscordCs.Entities.UserModels;

namespace FarDragi.DiscordCs.Caching
{
    public interface ICacheConfig
    {
        public ICaching<User> GetUserCaching();
        public ICaching<Guild> GetGuildCaching();
    }
}
