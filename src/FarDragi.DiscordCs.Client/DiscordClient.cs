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

        public DiscordClient(ClientConfig config)
        {
            config.Properties = new Models.Identify.IdentifyProperties
            {
                OS = Environment.OSVersion.Platform.ToString(),
                Browser = "DiscordCs",
                Device = "DiscordCs"
            };

            GatewayConfig gatewayConfig = new GatewayConfig
            {
                Identify = config
            };
            gateway = new GatewayClient(this, gatewayConfig);
        }

        public event EventHandler<string> Raw;
        public event EventHandler<string> Ready;

        public void Login()
        {
            gateway.Open();
        }

        public virtual void OnRaw(object sender, object data)
        {

        }

        [GatewayEvent("READY")]
        public virtual void OnReady(object sender, object data)
        {

        }
    }
}
