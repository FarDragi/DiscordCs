using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Caching
{
    public interface ICacheContext
    {
        public ICache<TEntity, TKeyType> GetCache<TEntity, TKeyType>();
    }
}
