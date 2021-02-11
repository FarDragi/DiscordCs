using FarDragi.DiscordCs.Entities.UserModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Caching.Standard.Caches
{
    public class UserCache : ICaching<User>
    {
        private readonly Dictionary<ulong, User> _dict;

        public UserCache()
        {
            _dict = new Dictionary<ulong, User>();
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
