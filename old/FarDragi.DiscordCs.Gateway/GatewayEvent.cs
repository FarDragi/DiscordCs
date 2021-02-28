using System;

namespace FarDragi.DiscordCs.Gateway
{
    public class GatewayEvent
    {
        public delegate void GatewayDelegate(GatewayClient client, object obj);

        public Type TypeConvert { get; set; }
        public GatewayDelegate Delegate { get; set; }
    }
}
