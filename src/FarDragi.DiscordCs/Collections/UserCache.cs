using FarDragi.DiscordCs.Entities.UserModels;
using FarDragi.DiscordCs.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FarDragi.DiscordCs.Collections
{
    public class UserCache : ICache<User>, IEnumerable<User>
    {
        private readonly Collection<User> users;
        private readonly Dictionary<ulong, User> keyUsers;
        private readonly Client client;

        public UserCache(Client client)
        {
            this.client = client;
            users = new Collection<User>();
            keyUsers = new Dictionary<ulong, User>();
        }

        public User this[ulong id] 
        {
            get
            {
                return keyUsers[id];
            }
            set
            {
                keyUsers[id] = value;
            }
        }

        public void Caching(User type)
        {
        }

        public IEnumerator<User> GetEnumerator()
        {
            return users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
