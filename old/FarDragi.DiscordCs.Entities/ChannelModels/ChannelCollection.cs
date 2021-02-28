using FarDragi.DiscordCs.Caching;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    public class ChannelCollection : ICacheable<Channel>
    {
        private readonly ICaching<Channel> _cache;

        public ChannelCollection(ICaching<Channel> cache)
        {
            _cache = cache;
        }

        public Channel this[in ulong id]
        {
            get
            {
                return _cache.Get(id);
            }
        }

        public Channel Caching(ref Channel data)
        {
            return _cache.Add(data.Id, data);
        }

        public IEnumerator<Channel> GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        public Channel Find(in ulong id)
        {
            return _cache.Get(id);
        }
    }
}
