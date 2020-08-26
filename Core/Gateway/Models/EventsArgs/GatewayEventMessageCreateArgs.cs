using FarDragi.DiscordCs.Core.Gateway.Models.Events;
using FarDragi.DiscordCs.Core.Gateway.Models.Payloads;
using FarDragi.DiscordCs.Core.Models.Event;

namespace FarDragi.DiscordCs.Core.Gateway.Models.EventsArgs
{
    internal class GatewayEventMessageCreateArgs
    {
        internal MessageCreate Data { get; }

        internal GatewayEventMessageCreateArgs(PayloadRecived<EventMessageCreate> payload)
        {
            
        }
    }
}
