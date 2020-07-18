using FarDragi.DiscordCs.Core.Base.Models.Event;
using FarDragi.DiscordCs.Core.Gateway.Models.Events;
using FarDragi.DiscordCs.Core.Gateway.Models.Payloads;

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
