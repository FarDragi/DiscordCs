using FarDragi.DiscordCs.Core.Models.Base.Emoji;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordEmojiList : DiscordList<DiscordEmoji>, IEnumerable<DiscordEmoji>
    {
        #region IEnumerable

        public IEnumerator<DiscordEmoji> GetEnumerator()
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
