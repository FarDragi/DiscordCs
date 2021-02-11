using FarDragi.DiscordCs.Entities.UserModels;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Caching.Standard.Caches
{
    public class UserCache : ICaching<User>
    {
        private readonly Dictionary<ulong, User> _dict;

        public UserCache()
        {
            _dict = new Dictionary<ulong, User>();
        }

        public User Add(User data)
        {
            if (_dict.TryAdd(data.Id, data))
            {
                return data;
            }

            return Get(data.Id);
        }

        public User Get(ulong id)
        {
            if (_dict.TryGetValue(id, out User result))
            {
                return result;
            }

            return null;
        }

        public IEnumerator<User> GetEnumerator()
        {
            return _dict.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
