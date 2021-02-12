namespace FarDragi.DiscordCs.Caching.Standard
{
    public class StandardCacheConfig : ICacheConfig
    {
        public ICaching<TType> GetCache<TType>() where TType : class
        {
            return new StandardCache<TType>();
        }
    }
}
