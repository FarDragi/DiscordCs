using FarDragi.DiscordCs.Core.Models.Base.Emoji;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordEmojiList : IEnumerable<DiscordEmoji>
    {
        private Collection<DiscordEmoji> _list;

        public DiscordEmojiList()
        {
            _list = new Collection<DiscordEmoji>();
        }

        #region Functions

        public void Add(DiscordEmoji emoji)
        {
            _list.Add(emoji);
        }

        #endregion

        #region MyRegion

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
