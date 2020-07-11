using FarDragi.DragiCordApi.Core.Base.Models.EventsArgs;
using FarDragi.DragiCordApi.Core.Gateway.Client;
using FarDragi.DragiCordApi.Core.Gateway.Models.EventsArgs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DragiCordApi.Core.Base.Client
{
    public class DiscordClientEvents : DiscordClientData
    {
        public delegate Task HandlerEventReady(ReadyEventArgs e);

        public event HandlerEventReady Ready;

        internal Task OnEventReady(GatewayReadyEventArgs e)
        {
            User = e.Data.User;
            Ready.Invoke(new ReadyEventArgs(e.Data));
            return Task.CompletedTask;
        }
    }
}
