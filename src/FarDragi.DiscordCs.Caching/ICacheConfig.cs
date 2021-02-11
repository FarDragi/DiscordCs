using FarDragi.DiscordCs.Entities.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Caching
{
    public interface ICacheConfig
    {
        public ICaching<User> GetUserCaching();
    }
}
