using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using FarDragi.DiscordCs.Logging;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class UserCollection : ICacheable<ulong, User>
    {
        private readonly ICache<ulong, User> _cache;
        private readonly ILogger _logger;

        public UserCollection(ICache<ulong, User> cache, ILogger logger)
        {
            _cache = cache;
            _logger = logger;
        }

        public User Caching(ref User entity, bool update = false)
        {
            _cache.Add(entity.Id, ref entity);
            return entity;
        }

        public async Task<User> Find(ulong key)
        {
            if (_cache.TryGet(key, out User user))
            {
                return user;
            }
            return null;
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
