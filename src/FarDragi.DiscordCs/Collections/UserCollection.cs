using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entities.UserModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Collections
{
    public class UserCollection : IEnumerable<User>
    {
        private readonly ICaching<User> _users;

        public UserCollection(ICaching<User> users)
        {
            _users = users;
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
