using FarDragi.DiscordCs.Core.Base.Models.Event;
using FarDragi.DiscordCs.Core.Gateway.Models.Events;
using FarDragi.DiscordCs.Core.Gateway.Models.Payloads;

namespace FarDragi.DiscordCs.Core.Gateway.Models.EventsArgs
{
    internal class GatewayEventGuildCreateArgs
    {
        internal GuildCreate Data;

        internal GatewayEventGuildCreateArgs(PayloadRecived<EventGuildCreate> payload)
        {
            Data = new GuildCreate
            {
                Id = payload.Data.Id,
                Name = payload.Data.Name
            };
        }
    }
}
