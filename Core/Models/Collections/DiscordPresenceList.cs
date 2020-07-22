using FarDragi.DiscordCs.Core.Models.Base.Presence;
using System;
using System.Collections;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordPresenceList : DiscordList<DiscordPresence>, IEnumerable<DiscordPresence>
    {
        #region IEnumerable

        public IEnumerator<DiscordPresence> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
