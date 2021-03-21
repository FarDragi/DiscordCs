using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.MessageModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class MessageCollection : ICacheable<ulong, Message>
    {
        private readonly ICache<ulong, Message> _cache;

        public MessageCollection(ICache<ulong, Message> cache)
        {
            _cache = cache;
        }

        public Message Caching(ref Message entity)
        {
            _cache.Add(entity.Id, ref entity);
            return entity;
        }

        public Message Find(ulong key)
        {
            return _cache.Get(key);
        }

        public IEnumerator<Message> GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cache.GetEnumerator();
        }
    }
}
