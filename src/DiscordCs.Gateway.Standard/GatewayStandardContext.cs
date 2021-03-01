using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Standard
{
    public class GatewayStandardContext : IGatewayContext
    {
        private readonly GatewayStandardConfig _config;

        public GatewayStandardContext(GatewayStandardConfig config)
        {
            _config = config;
        }

        public IGatewayClient GetClient(Identify identify)
        {
            return new GatewayStandardClient(identify, _config);
        }
    }
}
