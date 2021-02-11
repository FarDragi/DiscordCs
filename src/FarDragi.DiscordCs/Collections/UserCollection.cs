using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entities.UserModels;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Collections
{
    public class UserCollection : ICacheable<User>
    {
        private readonly ICaching<User> _users;

        public UserCollection(ICaching<User> users)
        {
            _users = users;
        }

        public User this[ulong id]
        {
            get
            {
                return _users.Get(id);
            }
        }

        public void Caching(User data)
        {
            _users.Add(data);
        }

        public IEnumerator<User> GetEnumerator()
        {
            return _users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _users.GetEnumerator();
        }
    }
}
