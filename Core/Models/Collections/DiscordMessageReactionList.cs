using FarDragi.DiscordCs.Core.Models.Base.Message;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordMessageReactionList : DiscordList<DiscordMessageReaction>, IEnumerable<DiscordMessageReaction>
    {
        #region IEnumerable

        public IEnumerator<DiscordMessageReaction> GetEnumerator()
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
