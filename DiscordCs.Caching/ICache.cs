using System.Collections.Generic;

namespace FarDragi.DiscordCs.Caching
{
    public interface ICache<TKeyType, TEntity> : IEnumerable<TEntity> where TEntity : class
    {
        public void Add(TKeyType key, ref TEntity entity);
        public void Remove(TKeyType key);
        public TEntity Get(TKeyType key);
        public void Set(TKeyType key, ref TEntity entity);
    }
}
