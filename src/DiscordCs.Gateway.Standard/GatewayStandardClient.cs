using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Gateway.Standard
{
    public class GatewayStandardClient : IGatewayClient
    {
        public Task Open()
        {
            Console.WriteLine("Abrindo...");
            return Task.CompletedTask;
        }
    }
}
