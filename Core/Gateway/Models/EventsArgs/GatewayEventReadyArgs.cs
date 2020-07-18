using FarDragi.DiscordCs.Core.Base.Models.Base.Guild;
using FarDragi.DiscordCs.Core.Base.Models.Event;
using FarDragi.DiscordCs.Core.Gateway.Models.Events;
using FarDragi.DiscordCs.Core.Gateway.Models.Payloads;

namespace FarDragi.DiscordCs.Core.Gateway.Models.EventsArgs
{
    internal class GatewayEventReadyArgs
    {
        internal Ready Data;

        internal GatewayEventReadyArgs(PayloadRecived<EventReady> payload)
        {
            Data = new Ready
            {
                Version = payload.Data.Version,
                User = new DiscordUser
                {
                    Id = payload.Data.User.Id,
                    Username = payload.Data.User.Username,
                    Discriminator = payload.Data.User.Discriminator,
                    IsBot = payload.Data.User.IsBot,
                    IsVerified = payload.Data.User.IsVerified,
                    IsSystem = payload.Data.User.IsSystem,
                    Avatar = payload.Data.User.Avatar,
                    Email = payload.Data.User.Email,
                    Locale = payload.Data.User.Locale,
                    MfaEnabled = payload.Data.User.MfaEnabled
                },
                SessionId = payload.Data.SessionId,
                Shards = new DiscordShards
                {
                    ShardId = payload.Data.Shard[0],
                    ShardCount = payload.Data.Shard[1]
                },
                Guilds = GetGuilds(payload.Data)
            };
        }

        internal DiscordGuild[] GetGuilds(EventReady ready)
        {
            DiscordGuild[] guilds = new DiscordGuild[ready.Guilds.Length];

            for (int i = 0; i < ready.Guilds.Length; i++)
            {
                guilds[i] = new DiscordGuild
                {
                    IsUnavailable = ready.Guilds[i].IsUnavailable,
                    Id = ready.Guilds[i].Id
                };
            }

            return guilds;
        }
    }
}
