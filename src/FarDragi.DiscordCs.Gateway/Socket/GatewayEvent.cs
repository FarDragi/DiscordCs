using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Socket
{
    public delegate void GatewayDelegate(GatewayClient client, object obj);

    public class GatewayEvent
    {
        public Type TypeConvert { get; set; }
        public GatewayDelegate Delegate { get; set; }
    }
}
