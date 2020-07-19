using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordList<T>
    {
        protected readonly Collection<T> _list;

        public DiscordList()
        {
            _list = new Collection<T>();
        }

        public virtual void Add(T entity)
        {
            _list.Add(entity);
        }
    }
}
