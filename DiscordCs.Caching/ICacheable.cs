using System.Collections.Generic;

namespace FarDragi.DiscordCs.Caching
{
    public interface ICacheable<TKeyType, TEntity> : IEnumerable<TEntity>
    {
        public TEntity Caching(ref TEntity entity, bool update = false);
        public TEntity Find(TKeyType key);
    }
}
