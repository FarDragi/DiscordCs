using FarDragi.DiscordCs.Caching;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.UserModels
{
    public class UserCollection : ICacheable<User>
    {
        private readonly ICaching<User> _users;

        public UserCollection(ICaching<User> users)
        {
            _users = users;
        }

        public User this[in ulong id]
        {
            get
            {
                return _users.Get(id);
            }
        }

        public void Caching(ref User data)
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
