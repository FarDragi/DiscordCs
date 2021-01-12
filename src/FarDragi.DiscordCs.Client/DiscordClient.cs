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
        private GatewayClient gateway;

        public DiscordClient()
        {
            gateway = new GatewayClient(this);
        }

        public event IGatewayEvents.HandlerGateway<string> Raw;

        public void Login(string token)
        {
            gateway.Open();
        }

        [EventName("RAW")]
        public void OnRaw(object sender, object data)
        {
            throw new NotImplementedException();
        }
    }
}
