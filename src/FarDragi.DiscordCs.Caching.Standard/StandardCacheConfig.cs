using FarDragi.DiscordCs.Caching.Standard.Caches;
using FarDragi.DiscordCs.Entities.GuildModels;
using FarDragi.DiscordCs.Entities.Interfaces;
using FarDragi.DiscordCs.Entities.UserModels;

namespace FarDragi.DiscordCs.Caching.Standard
{
    public static class StandardCacheConfig
    {
        public static void UseStandardCache(this ICollections collections)
        {
            collections.Guilds = new GuildCollection(new GuildCache());
            collections.Users = new UserCollection(new UserCache());
        }
    }
}
