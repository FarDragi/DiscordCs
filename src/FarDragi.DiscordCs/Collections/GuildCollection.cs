using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entities.GuildModels;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Collections
{
    public class GuildCollection : ICacheable<Guild>
    {
        private readonly ICaching<Guild> _guilds;

        public GuildCollection(ICaching<Guild> guilds)
        {
            _guilds = guilds;
        }

        public Guild this[ulong id]
        {
            get
            {
                return _guilds.Get(id);
            }
        }

        public void Caching(Guild data)
        {
            _guilds.Add(data);
        }

        public IEnumerator<Guild> GetEnumerator()
        {
            return _guilds.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _guilds.GetEnumerator();
        }
    }
}
