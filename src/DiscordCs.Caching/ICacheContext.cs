namespace FarDragi.DiscordCs.Caching
{
    public interface ICacheContext
    {
        public ICache<TEntity, TKeyType> GetCache<TEntity, TKeyType>();
    }
}
