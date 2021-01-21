using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Interfaces
{
    public interface ICache<TType>
    {
        public TType this[ulong id] { get; set; }

        public void Caching(TType type);
    }
}
