using FarDragi.DiscordCs.Core.Models.Base.Voice;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordVoiceList : DiscordList<DiscordVoice>, IEnumerable<DiscordVoice>
    {
        #region IEnumerable

        public IEnumerator<DiscordVoice> GetEnumerator()
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
