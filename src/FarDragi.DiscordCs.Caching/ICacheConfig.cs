namespace FarDragi.DiscordCs.Caching
{
    public interface ICacheConfig
    {
        public ICaching<TType> GetCache<TType>() where TType : class;
    }
}
