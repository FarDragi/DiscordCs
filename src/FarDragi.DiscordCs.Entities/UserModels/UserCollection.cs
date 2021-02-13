using FarDragi.DiscordCs.Caching;
using System.Collections;
using System.Collections.Generic;

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

        public User Caching(ref User data)
        {
            return _users.Add(data.Id, data);
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
