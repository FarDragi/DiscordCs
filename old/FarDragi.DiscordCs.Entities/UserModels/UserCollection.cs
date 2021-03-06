﻿using FarDragi.DiscordCs.Caching;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entities.UserModels
{
    public class UserCollection : ICacheable<User>
    {
        private readonly ICaching<User> _cache;

        public UserCollection(ICaching<User> cache)
        {
            _cache = cache;
        }

        public User this[in ulong id]
        {
            get
            {
                return _cache.Get(id);
            }
        }

        public User Caching(ref User data)
        {
            return _cache.Add(data.Id, data);
        }

        public User Find(in ulong id)
        {
            return _cache.Get(id);
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
