using FarDragi.DiscordCs.Entities.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Caching.Standard
{
    public class StandardCacheConfig : ICacheConfig
    {
        public ICaching<User> GetUserCaching()
        {
            return new UserCache();
        }
    }
}
