using FarDragi.DiscordCs.Caching;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.PermissionModels
{
    public class PermissionOverwriteCollection : ICacheable<PermissionOverwrite>
    {
        private readonly ICaching<PermissionOverwrite> _permissionOverwrites;

        public PermissionOverwriteCollection(ICaching<PermissionOverwrite> permissionOverwrites)
        {
            _permissionOverwrites = permissionOverwrites;
        }

        public PermissionOverwrite this[in ulong id]
        {
            get
            {
                return _permissionOverwrites.Get(id);
            }
        }

        public PermissionOverwrite Caching(ref PermissionOverwrite data)
        {
            return _permissionOverwrites.Add(data.Id, data);
        }

        public IEnumerator<PermissionOverwrite> GetEnumerator()
        {
            return _permissionOverwrites.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _permissionOverwrites.GetEnumerator();
        }
    }
}
