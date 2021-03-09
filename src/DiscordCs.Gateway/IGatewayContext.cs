using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway
{
    public interface IGatewayContext
    {
        IGatewayClient GetClient(Identify identify, ILogger logger);
    }
}
