using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.MemberModels;
using FarDragi.DiscordCs.Logging;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class MemberCollection : ICacheable<ulong, Member>
    {
        private readonly ICache<ulong, Member> _cache;
        private readonly ILogger _logger;

        public MemberCollection(ICache<ulong, Member> cache, ILogger logger)
        {
            _cache = cache;
            _logger = logger;
        }

        public Member Caching(ref Member entity)
        {
            _cache.Add(entity.User.Id, ref entity);
            return entity;
        }

        public Member Find(ulong key)
        {
            return _cache.Get(key);
        }

        public IEnumerator<Member> GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cache.GetEnumerator();
        }
    }
}
