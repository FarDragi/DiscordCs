using FarDragi.DiscordCs.Core.Models.Base.Role;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Collections
{
    public class DiscordRoleList : IEnumerable<DiscordRole>
    {
        private readonly Collection<DiscordRole> _list;

        public DiscordRoleList()
        {
            _list = new Collection<DiscordRole>();
        }

        #region Functions

        public void Add(DiscordRole role)
        {
            _list.Add(role);
        }

        #endregion

        #region IEnumarable

        public IEnumerator<DiscordRole> GetEnumerator()
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
