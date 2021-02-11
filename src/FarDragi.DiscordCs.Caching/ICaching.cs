using System.Collections.Generic;

namespace FarDragi.DiscordCs.Caching
{
    public interface ICaching<TType> : IEnumerable<TType>
    {
    }
}
