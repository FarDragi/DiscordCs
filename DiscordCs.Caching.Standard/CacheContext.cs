namespace FarDragi.DiscordCs.Caching.Standard
{
    public class CacheContext : ICacheContext
    {
        private readonly CacheConfig _cacheConfig;

        public CacheContext(CacheConfig cacheConfig)
        {
            _cacheConfig = cacheConfig;
        }

        public ICache<TKeyType, TEntity> GetCache<TKeyType, TEntity>() where TEntity: class
        {
            return new Cache<TKeyType, TEntity>();
        }
    }
}
