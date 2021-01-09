using FarDragi.DiscordCs.Gateway.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Client
{
    public class DiscordGateway
    {
        private IGatewayEvents events;

        public DiscordGateway(IGatewayEvents events)
        {
            this.events = events;
        }
    }
}
