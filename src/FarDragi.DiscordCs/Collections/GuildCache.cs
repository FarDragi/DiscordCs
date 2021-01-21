using FarDragi.DiscordCs.Entities.GuildModels;
using FarDragi.DiscordCs.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FarDragi.DiscordCs.Caching
{
    public class GuildCache : ICache<Guild>, IEnumerable<Guild>
    {
        private readonly Collection<Guild> guilds;
        private readonly Dictionary<ulong, Guild> keyGuilds;
        private readonly Client client;

        public GuildCache(Client client)
        {
            this.client = client;
            guilds = new Collection<Guild>();
            keyGuilds = new Dictionary<ulong, Guild>();
        }

        public Guild this[ulong id]
        {
            get
            {
                return keyGuilds[id];
            }
            set
            {
                keyGuilds[id] = value;
            }
        }

        public void Caching(Guild type)
        {

        }

        public IEnumerator<Guild> GetEnumerator()
        {
            return guilds.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
