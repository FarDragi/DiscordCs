﻿using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class UserCollection : ICacheable<ulong, User>
    {
        private readonly ICache<ulong, User> _cache;

        public UserCollection(ICache<ulong, User> cache)
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
