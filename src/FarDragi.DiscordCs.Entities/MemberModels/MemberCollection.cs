using FarDragi.DiscordCs.Caching;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entities.MemberModels
{
    public class MemberCollection : ICacheable<Member>
    {
        private readonly ICaching<Member> _members;

        public MemberCollection(ICaching<Member> members)
        {
            _members = members;
        }

        public Member this[in ulong id]
        {
            get
            {
                return _members.Get(id);
            }
        }

        public Member Caching(ref Member data)
        {
            return _members.Add(data.User.Id, data);
        }

        public IEnumerator<Member> GetEnumerator()
        {
            return _members.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _members.GetEnumerator();
        }
    }
}
