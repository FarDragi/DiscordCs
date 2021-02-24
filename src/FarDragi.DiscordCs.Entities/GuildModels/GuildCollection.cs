using FarDragi.DiscordCs.Caching;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entities.GuildModels
{
    public class GuildCollection : ICacheable<Guild>
    {
        private readonly ICaching<Guild> _cache;

        public GuildCollection(ICaching<Guild> cache)
        {
            _cache = cache;
        }

        public Guild this[in ulong id]
        {
            get
            {
                return _cache.Get(id);
            }
        }

        public Guild Caching(ref Guild data)
        {
            return _cache.Add(data.Id, data);
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
