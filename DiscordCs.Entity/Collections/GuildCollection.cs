using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using FarDragi.DiscordCs.Logging;
using System.Collections;
using System.Collections.Generic;

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

        public Guild Find(ulong key)
        {
            return _cache.Get(key);
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
