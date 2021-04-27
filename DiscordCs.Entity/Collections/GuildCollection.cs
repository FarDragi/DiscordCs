using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using FarDragi.DiscordCs.Logging;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class GuildCollection : ICacheable<ulong, Guild>
    {
        private readonly ICache<ulong, Guild> _cache;
        private readonly ILogger _logger;

        public GuildCollection(ICache<ulong, Guild> cache, ILogger logger)
        {
            _cache = cache;
            _logger = logger;
        }

        public Guild Caching(ref Guild entity, bool update = false)
        {
            _cache.Add(entity.Id, ref entity);
            return entity;
        }

        public async Task<Guild> Find(ulong key)
        {
            if (_cache.TryGet(key, out Guild guild))
            {
                return guild;
            }
            return null;
        }

        public IEnumerator<Guild> GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cache.GetEnumerator();
        }
    }
}
