using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Caching
{
    public interface ICacheable<TKeyType, TEntity> : IEnumerable<TEntity>
    {
        public TEntity Caching(ref TEntity entity);
        public TEntity Find(TKeyType key);
    }
}
