using FarDragi.DiscordCs.Core.Models.Base.Channel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordCategoryChannelList : DiscordList<DiscordCategoryChannel>, IEnumerable<DiscordCategoryChannel>
    {
        #region IEnumerable

        public IEnumerator<DiscordCategoryChannel> GetEnumerator()
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
