using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class GuildCollection : ICacheable<ulong, Guild>
    {
        private readonly ICache<ulong, Guild> _cache;

        public GuildCollection(ICache<ulong, Guild> cache)
        {
            _cache = cache;
        }

        public Guild Caching(ref Guild entity)
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
