using FarDragi.DiscordCs.Core.Models.Base.Guild;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordGuildList : DiscordList<DiscordGuild>, IEnumerable<DiscordGuild>
    {
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
