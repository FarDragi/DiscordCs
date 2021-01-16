using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs
{
    public class Client
    {
        private readonly ClientConfig config;

        public Client(ClientConfig clientConfig)
        {
            config = clientConfig;
        }
    }
}
