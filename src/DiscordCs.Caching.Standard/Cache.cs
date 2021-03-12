using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FarDragi.DiscordCs.Caching.Standard
{
    public class Cache<TEntity, TKeyType> : ICache<TEntity, TKeyType>
    {
        private Collection<TEntity> _entities { get; set; }

        public Cache()
        {
            _entities = new Collection<TEntity>();
        }

        public Cache(Cache<TEntity, TKeyType> cache)
        {
            _entities = cache._entities;
        }

        public void Add(TKeyType key, ref TEntity entity)
        {
            _entities.Add(entity);
        }

        public TEntity Get(TKeyType key)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Remove(TKeyType key)
        {
            throw new NotImplementedException();
        }

        public void Set(TKeyType key, ref TEntity entity)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
