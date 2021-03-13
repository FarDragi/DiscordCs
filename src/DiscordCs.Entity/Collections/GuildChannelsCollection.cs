using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class GuildChannelsCollection : ICacheable<ulong, GuildChannel>
    {
        private readonly ICache<ulong, GuildChannel> _cache;

        public GuildChannelsCollection(ICache<ulong, GuildChannel> cache)
        {
            _cache = cache;
        }

        public GuildChannel Caching(ref GuildChannel entity)
        {
            _cache.Add(entity.Id, ref entity);
            return entity;
        }

        public GuildChannel Find(ulong key)
        {
            return _cache.Get(key);
        }

        public IEnumerator<GuildChannel> GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cache.GetEnumerator();
        }
    }
}
