using FarDragi.DiscordCs.Core.Interfaces.Identify;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway
{
    public class GatewayConfig
    {
        public IDiscordIdentify Identify { get; set; }
    }
}
