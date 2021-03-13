using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace FarDragi.DiscordCs.Caching.Standard
{
    public class Cache<TEntity, TKeyType> : ICache<TEntity, TKeyType>
    {
        private SortedList<TKeyType, TEntity> _entities { get; set; }

        public Cache()
        {
            _entities = new SortedList<TKeyType, TEntity>();
        }

        public Cache(Cache<TEntity, TKeyType> cache)
        {
            _entities = cache._entities;
        }

        public void Add(TKeyType key, ref TEntity entity)
        {
            lock (_entities)
            {
                if (!_entities.TryAdd(key, entity))
                {
                    entity = Get(key);
                }
            }
        }

        public void Remove(TKeyType key)
        {
            lock (_entities)
            {
                _entities.Remove(key);
            }
        }

        public TEntity Get(TKeyType key)
        {
            return _entities[key];
        }

        public void Set(TKeyType key, ref TEntity entity)
        {
            _entities[key] = entity;
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            return _entities.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return _entities.Values;
        }
    }
}
