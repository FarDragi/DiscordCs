using FarDragi.DiscordCs.Caching;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entities.PresenceModels
{
    public class PresenceCollection : ICacheable<Presence>
    {
        private readonly ICaching<Presence> _cache;

        public PresenceCollection(ICaching<Presence> cache)
        {
            _cache = cache;
        }

        public Presence this[in ulong id]
        {
            get
            {
                return _cache.Get(id);
            }
        }

        public Presence Caching(ref Presence data)
        {
            return _cache.Add(data.User.Id, data);
        }

        public Presence Find(in ulong id)
        {
            return _cache.Get(id);
        }

        public IEnumerator<Presence> GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cache.GetEnumerator();
        }
    }
}
