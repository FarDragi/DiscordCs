using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.MemberModels;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class MemberCollection : ICacheable<ulong, Member>
    {
        private readonly ICache<ulong, Member> _cache;

        public MemberCollection(ICache<ulong, Member> cache)
        {
            _cache = cache;
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
