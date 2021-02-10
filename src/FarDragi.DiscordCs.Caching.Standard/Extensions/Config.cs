using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Caching.Standard.Extensions
{
    public static class Config
    {
        public static void UseStandard(this ClientConfig config)
        {
            config.CachingConfig = (client) =>
            {

            };
        }
    }
}
