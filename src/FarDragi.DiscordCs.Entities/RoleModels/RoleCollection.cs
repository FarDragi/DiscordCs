using FarDragi.DiscordCs.Caching;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entities.RoleModels
{
    public class RoleCollection : ICacheable<Role>
    {
        private readonly ICaching<Role> _roles;

        public RoleCollection(ICaching<Role> roles)
        {
            _roles = roles;
        }

        public Role this[in ulong id]
        {
            get
            {
                return _roles.Get(id);
            }
        }

        public Role Caching(ref Role data)
        {
            return _roles.Add(data.Id, data);
        }

        public IEnumerator<Role> GetEnumerator()
        {
            return _roles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _roles.GetEnumerator();
        }
    }
}
