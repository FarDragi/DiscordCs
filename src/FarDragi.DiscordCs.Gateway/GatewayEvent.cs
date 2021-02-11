using System;

namespace FarDragi.DiscordCs.Gateway
{
    public delegate void GatewayDelegate(GatewayClient client, object obj);

    public class GatewayEvent
    {
        public Type TypeConvert { get; set; }
        public GatewayDelegate Delegate { get; set; }
    }
}
