using FarDragi.DiscordCs.Entities.GuildModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Caching.Standard.Caches
{
    public class GuildCache : ICaching<Guild>
    {
        private readonly Dictionary<ulong, Guild> _dict;

        public GuildCache()
        {
            _dict = new Dictionary<ulong, Guild>();
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
