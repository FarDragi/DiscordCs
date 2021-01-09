using FarDragi.DiscordCs.Gateway;
using FarDragi.DiscordCs.Gateway.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Client
{
    public class DiscordClient : IGatewayEvents
    {
        private GatewayClient gateway;

        public DiscordClient()
        {
            gateway = new GatewayClient(this);
        }
    }
}
