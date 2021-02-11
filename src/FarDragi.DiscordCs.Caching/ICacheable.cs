using System.Collections.Generic;

namespace FarDragi.DiscordCs.Caching
{
    public interface ICacheable<TType> : IEnumerable<TType>
    {
    }
}
