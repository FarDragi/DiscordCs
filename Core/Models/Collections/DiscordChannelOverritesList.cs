using FarDragi.DiscordCs.Core.Models.Base.Channel;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordChannelOverritesList : DiscordList<DiscordChannelOverrites>, IEnumerable<DiscordChannelOverrites>
    {
        #region IEnumerable

        public IEnumerator<DiscordChannelOverrites> GetEnumerator()
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
