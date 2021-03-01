using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Standard
{
    public class GatewayStandardContext : IGatewayContext
    {
        public IGatewayClient GetClient(Identify identify)
        {
            return new GatewayStandardClient();
        }
    }
}
