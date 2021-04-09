using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using FarDragi.DiscordCs.Logging;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class ChannelCollection : ICacheable<ulong, Channel>
    {
        private readonly ICache<ulong, Channel> _cache;
        private readonly ILogger _logger;

        public ChannelCollection(ICache<ulong, Channel> cache, ILogger logger)
        {
            _cache = cache;
            _logger = logger;
        }

        public Channel Caching(ref Channel entity, bool update = false)
        {
            _cache.Add(entity.Id, ref entity);
            return entity;
        }

        public Channel Find(ulong key)
        {
            return _cache.Get(key);
        }

        public IEnumerator<Channel> GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cache.GetEnumerator();
        }
    }
}
