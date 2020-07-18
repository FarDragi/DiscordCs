using FarDragi.DiscordCs.Core.Gateway.Models.Events;
using FarDragi.DiscordCs.Core.Gateway.Models.Payloads;
using FarDragi.DiscordCs.Core.Models.Base.Guild;
using FarDragi.DiscordCs.Core.Models.Event;

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
                Name = payload.Data.Name,
                Description = payload.Data.Description,
                Icon = payload.Data.Icon,
                OwnerId = payload.Data.OwnerId,
                Region = payload.Data.Region,
                Splash = payload.Data.Splash,
                DiscoverySplash = payload.Data.DiscoverySplash,
                IsUnavailable = payload.Data.IsUnavailable,
                AfkConfig = new DiscordGuildAfkConfig
                {
                    AfkChannelId = payload.Data.AfkChannelId,
                    AfkTimeout = payload.Data.AfkTimeout
                },
                EmbedConfig = new DiscordGuildEmbedConfig
                {
                    EmbedChannelId = payload.Data.EmbedChannelId,
                    EmbedEnabled = payload.Data.EmbedEnabled
                }
            };
        }
    }
}
