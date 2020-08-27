using FarDragi.DiscordCs.Core.Models.Base.Embed;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordFieldList : DiscordList<DiscordField>, IEnumerable<DiscordField>
    {
        #region IEnumerable

        public IEnumerator<DiscordField> GetEnumerator()
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
