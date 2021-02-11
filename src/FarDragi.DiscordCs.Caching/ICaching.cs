using System.Collections.Generic;

namespace FarDragi.DiscordCs.Caching
{
    public interface ICaching<TType> : IEnumerable<TType>
    {
        public TType Get(ulong id);
        public TType Add(TType data);
    }
}
