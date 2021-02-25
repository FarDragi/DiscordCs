using FarDragi.DiscordCs.Caching;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entities.MemberModels
{
    public class MemberCollection : ICacheable<Member>
    {
        private readonly ICaching<Member> _cache;

        public MemberCollection(ICaching<Member> cache)
        {
            _cache = cache;
        }

        public Member this[in ulong id]
        {
            get
            {
                return _cache.Get(id);
            }
        }

        public Member Caching(ref Member data)
        {
            return _cache.Add(data.User.Id, data);
        }

        public Member Find(in ulong id)
        {
            return _cache.Get(id);
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
