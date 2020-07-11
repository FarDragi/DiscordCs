using FarDragi.DragiCordApi.Core.Gateway.Models.EventsArgs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DragiCordApi.Core.Gateway.Client
{
    internal class GatewayClientEvents
    {
        public delegate Task HandlerEventReady(GatewayReadyEventArgs e);

        public event HandlerEventReady Ready;

        public void OnEventReady(GatewayReadyEventArgs e)
        {
            Ready?.Invoke(e);
        }
    }
}
