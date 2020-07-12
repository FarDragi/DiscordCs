using FarDragi.DiscordCs.Core.Base.Models.EventsArgs;
using FarDragi.DiscordCs.Core.Gateway.Client;
using FarDragi.DiscordCs.Core.Gateway.Models.EventsArgs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Core.Base.Client
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
