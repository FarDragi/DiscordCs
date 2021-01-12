using FarDragi.DiscordCs.Gateway.Interface;
using FarDragi.DiscordCs.Gateway.Socket;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway
{
    public class GatewayClient
    {
        private IGatewayEvents events;
        private WebSocketClient webSocket;

        public GatewayClient(IGatewayEvents events)
        {
            this.events = events;
        }

        public void Open()
        {
            webSocket.Open();
        }
    }
}
