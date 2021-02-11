using System.Collections.Generic;

namespace FarDragi.DiscordCs.Caching
{
    public interface ICacheable<TType> : IEnumerable<TType>
    {
        public void Caching(TType data);

        public TType this[ulong id] { get; }
    }
}
