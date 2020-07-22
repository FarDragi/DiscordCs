using System.Collections.ObjectModel;

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
