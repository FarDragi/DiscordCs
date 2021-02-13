using FarDragi.DiscordCs.Caching;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Entities.GuildModels
{
    public class GuildCollection : ICacheable<Guild>
    {
        private readonly ICaching<Guild> _guilds;

        public GuildCollection(ICaching<Guild> guilds)
        {
            _guilds = guilds;
        }

        public Guild this[in ulong id]
        {
            get
            {
                return _guilds.Get(id);
            }
        }

        public Guild Caching(ref Guild data)
        {
            return _guilds.Add(data.Id, data);
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
