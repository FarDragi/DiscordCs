using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Interfaces
{
    public interface IGatewayEvents
    {
        public event EventHandler<string> Raw;

        public void OnRaw(object sender, object data);
    }
}
