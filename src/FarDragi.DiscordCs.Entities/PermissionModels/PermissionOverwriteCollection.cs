using FarDragi.DiscordCs.Caching;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entities.PermissionModels
{
    public class PermissionOverwriteCollection : ICacheable<PermissionOverwrite>
    {
        private readonly ICaching<PermissionOverwrite> _cache;

        public PermissionOverwriteCollection(ICaching<PermissionOverwrite> permissionOverwrites)
        {
            _cache = permissionOverwrites;
        }

        public PermissionOverwrite this[in ulong id]
        {
            get
            {
                return _cache.Get(id);
            }
        }

        public PermissionOverwrite Caching(ref PermissionOverwrite data)
        {
            return _cache.Add(data.Id, data);
        }

        public PermissionOverwrite Find(in ulong id)
        {
            return _cache.Get(id);
        }

        public IEnumerator<PermissionOverwrite> GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cache.GetEnumerator();
        }
    }
}
