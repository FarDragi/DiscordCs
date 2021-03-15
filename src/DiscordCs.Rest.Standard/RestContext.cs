using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Rest.Standard
{
    public class RestContext : IRestContext
    {
        private readonly RestConfig _config;

        public RestContext(RestConfig config)
        {
            _config = config;
        }

        public IRestConfig Config { get => _config; }
    }
}
