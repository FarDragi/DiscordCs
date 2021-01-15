using FarDragi.DiscordCs.Gateway.Models.Payload;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Gateway.Interface
{
    public interface IGatewayEvents
    {
        public event EventHandler<string> Raw;

        public void OnRaw(object sender, object data);
    }
}
