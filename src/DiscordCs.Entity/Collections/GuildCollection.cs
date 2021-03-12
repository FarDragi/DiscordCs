using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class GuildCollection : ICacheable<Guild, ulong>, IEnumerable<Guild>
    {
        private readonly ICache<Guild, ulong> _cache;

        public GuildCollection(ICache<Guild, ulong> cache)
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
