﻿using System.Collections.Generic;

namespace FarDragi.DiscordCs.Caching
{
    public interface ICacheable<TType> : IEnumerable<TType>
    {
        public TType Caching(ref TType data);
        public TType this[in ulong id] { get; }
        public TType Find(in ulong id);
    }
}
