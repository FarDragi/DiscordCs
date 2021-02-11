using FarDragi.DiscordCs.Entities.GuildModels;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Caching.Standard.Caches
{
    public class GuildCache : ICaching<Guild>
    {
        private readonly Dictionary<ulong, Guild> _dict;

        public GuildCache()
        {
            _dict = new Dictionary<ulong, Guild>();
        }

        public Guild Add(Guild data)
        {
            if (_dict.TryAdd(data.Id, data))
            {
                return data;
            }

            return Get(data.Id);
        }

        public Guild Get(ulong id)
        {
            if (_dict.TryGetValue(id, out Guild result))
            {
                return result;
            }

            return null;
        }

        public IEnumerator<Guild> GetEnumerator()
        {
            return _dict.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
