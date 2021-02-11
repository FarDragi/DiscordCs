using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Caching
{
    public interface ICacheable<TType> : IEnumerable<TType>
    {
    }
}
