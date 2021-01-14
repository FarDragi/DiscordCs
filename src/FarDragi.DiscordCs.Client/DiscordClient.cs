using FarDragi.DiscordCs.Gateway;
using FarDragi.DiscordCs.Gateway.Attributes;
using FarDragi.DiscordCs.Gateway.Interface;
using FarDragi.DiscordCs.Gateway.Models.Payload;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Client
{
    public class DiscordClient : IGatewayEvents
    {
        private readonly GatewayClient gateway;

        public DiscordClient()
        {
            gateway = new GatewayClient(this);
        }

        public event HandlerGateway<string> Raw;
        public event HandlerGateway<string> Ready;

        public void Login(string token)
        {
            gateway.Open();
        }

        public virtual void OnRaw(object sender, object data)
        {

        }

        [EventName("READY")]
        public virtual void OnReady(object sender, object data)
        {

        }
    }
}
