namespace FarDragi.DiscordCs.Caching
{
    public interface ICacheContext
    {
        public ICache<TKeyType, TEntity> GetCache<TKeyType, TEntity>() where TEntity : class;
    }
}
