using FarDragi.DiscordCs.Core.Models.Base.Embed;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordEmbedList : DiscordList<DiscordEmbed>, IEnumerable<DiscordEmbed>
    {
        #region IEnumerable

        public IEnumerator<DiscordEmbed> GetEnumerator()
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
