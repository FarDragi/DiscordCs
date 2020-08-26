using FarDragi.DiscordCs.Core.Models.Base.Message;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordMessageAttachmentList : DiscordList<DiscordMessageAttachment>, IEnumerable<DiscordMessageAttachment>
    {
        #region IEnumerable

        public IEnumerator<DiscordMessageAttachment> GetEnumerator()
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
