using FarDragi.DiscordCs.Core.Models.Base.Member;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordMemberList : DiscordList<DiscordMember>, IEnumerable<DiscordMember>
    {
        #region IEnumerable

        public IEnumerator<DiscordMember> GetEnumerator()
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
