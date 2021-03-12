using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class UserCollection : ICacheable<User, ulong>
    {
        private ICache<User, ulong> _cache;

        public UserCollection(ICache<User, ulong> cache)
        {
            _cache = cache;
        }

        public User Caching(ref User entity)
        {
            _cache.Add(entity.Id, ref entity);
            return entity;
        }

        public User Find(ulong key)
        {
            return _cache.Get(key);
        }

        public IEnumerator<User> GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cache.GetEnumerator();
        }
    }
}
