using FarDragi.DiscordCs.Gateway.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway
{
    public class GatewayClient
    {
        private IGatewayEvents events;

        public GatewayClient(IGatewayEvents events)
        {
            this.events = events;
        }
    }
}
