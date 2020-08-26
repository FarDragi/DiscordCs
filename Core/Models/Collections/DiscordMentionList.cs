using FarDragi.DiscordCs.Core.Models.Base.User;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordMentionList : DiscordList<DiscordUserMention>, IEnumerable<DiscordUserMention>
    {
        #region IEnumerable

        public IEnumerator<DiscordUserMention> GetEnumerator()
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
