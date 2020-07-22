using FarDragi.DiscordCs.Core.Models.Base.Role;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordRoleList : DiscordList<DiscordRole>, IEnumerable<DiscordRole>
    {
        #region IEnumarable

        public IEnumerator<DiscordRole> GetEnumerator()
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
