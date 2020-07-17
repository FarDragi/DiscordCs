using FarDragi.DiscordCs.Core.Base.Models.Base;
using FarDragi.DiscordCs.Core.Rest.Client;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FarDragi.DiscordCs.Core.Base.Models.Collections
{
    public class DiscordGuildList : IEnumerable<DiscordGuild>
    {
        private readonly Collection<DiscordGuild> _list;
        private readonly RestClient _client;

        internal DiscordGuildList(RestClient client)
        {
            _client = client;
            _list = new ObservableCollection<DiscordGuild>();
        }

        public DiscordGuild this[ulong id]
        {
            get
            {
                return _list.SingleOrDefault(x => x.Id == id);
            }
        }
        public DiscordGuild this[string name]
        {
            get
            {
                return _list.SingleOrDefault(x => x.Name == name);
            }
        }

        #region Functions

        internal void Add(DiscordGuild guild)
        {
            _list.Add(guild);
        }

        #endregion

        #region IEnumerable

        public IEnumerator<DiscordGuild> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
