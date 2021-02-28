using FarDragi.DiscordCs.Caching;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entities.RoleModels
{
    public class RoleCollection : ICacheable<Role>
    {
        private readonly ICaching<Role> _cache;

        public RoleCollection(ICaching<Role> cache)
        {
            _cache = cache;
        }

        public Role this[in ulong id]
        {
            get
            {
                return _cache.Get(id);
            }
        }

        public Role Caching(ref Role data)
        {
            return _cache.Add(data.Id, data);
        }

        public Role Find(in ulong id)
        {
            return _cache.Get(id);
        }

        public IEnumerator<Role> GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cache.GetEnumerator();
        }
    }
}
