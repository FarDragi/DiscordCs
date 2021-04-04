using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Caching.Standard
{
    public class Cache<TKeyType, TEntity> : ICache<TKeyType, TEntity> where TEntity: class
    {
        private SortedList<TKeyType, TEntity> _entities { get; set; }

        public Cache()
        {
            _entities = new SortedList<TKeyType, TEntity>();
        }

        public Cache(Cache<TKeyType, TEntity> cache)
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
            if (_entities.TryGetValue(key, out TEntity entity))
            {
                return entity;
            }
            return null;
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
            return (IEnumerator)_entities.Values;
        }
    }
}
