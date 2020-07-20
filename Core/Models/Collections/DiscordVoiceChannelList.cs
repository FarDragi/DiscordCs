using FarDragi.DiscordCs.Core.Models.Base.Channel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordVoiceChannelList : DiscordList<DiscordVoiceChannel>, IEnumerable<DiscordVoiceChannel>
    {
        #region IEnumerable

        public IEnumerator<DiscordVoiceChannel> GetEnumerator()
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
