using FarDragi.DiscordCs.Caching.Standard.Caches;
using FarDragi.DiscordCs.Entities.GuildModels;
using FarDragi.DiscordCs.Entities.UserModels;

namespace FarDragi.DiscordCs.Caching.Standard
{
    public class StandardCacheConfig : ICacheConfig
    {
        public ICaching<Guild> GetGuildCaching()
        {
            return new GuildCache();
        }

        public ICaching<User> GetUserCaching()
        {
            return new UserCache();
        }
    }
}
