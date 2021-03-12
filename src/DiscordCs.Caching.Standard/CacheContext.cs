using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Caching.Standard
{
    public class CacheContext : ICacheContext
    {
        private readonly CacheConfig _cacheConfig;

        public CacheContext(CacheConfig cacheConfig)
        {
            _cacheConfig = cacheConfig;
        }

        public ICache<TEntity, TKeyType> GetCache<TEntity, TKeyType>()
        {
            return new Cache<TEntity, TKeyType>();
        }
    }
}
