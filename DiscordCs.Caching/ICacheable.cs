using System.Collections.Generic;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Caching
{
    public interface ICacheable<TKeyType, TEntity> : IEnumerable<TEntity>
    {
        public TEntity Caching(ref TEntity entity, bool update = false);
        public Task<TEntity> Find(TKeyType key);
    }
}
