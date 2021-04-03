using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using FarDragi.DiscordCs.Logging;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class GuildChannelsCollection : ICacheable<ulong, GuildChannel>
    {
        private readonly ICache<ulong, GuildChannel> _cache;
        private readonly ILogger _logger;

        public GuildChannelsCollection(ICache<ulong, GuildChannel> cache, ILogger logger)
        {
            _cache = cache;
            _logger = logger;
        }

        public GuildChannel Caching(ref GuildChannel entity, bool update = false)
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
