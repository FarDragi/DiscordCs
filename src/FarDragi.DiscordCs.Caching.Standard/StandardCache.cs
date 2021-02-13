using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Caching.Standard
{
    public class StandardCache<TType> : ICaching<TType> where TType : class
    {
        private readonly Dictionary<ulong, TType> _dict;
        private readonly object _lockAdd;

        public StandardCache()
        {
            _dict = new Dictionary<ulong, TType>();
            _lockAdd = new object();
        }

        public TType Add(ulong id, TType data)
        {
            lock (_lockAdd)
            {
                if (_dict.TryAdd(id, data))
                {
                    return data;
                }
            }

            return Get(id);
        }

        public TType Get(ulong id)
        {
            if (_dict.TryGetValue(id, out TType result))
            {
                return result;
            }

            return null;
        }

        public IEnumerator<TType> GetEnumerator()
        {
            return _dict.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
