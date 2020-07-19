using FarDragi.DiscordCs.Core.Gateway.Models.Events;
using FarDragi.DiscordCs.Core.Gateway.Models.Payloads;
using FarDragi.DiscordCs.Core.Models.Base.Guild;
using FarDragi.DiscordCs.Core.Models.Base.Role;
using FarDragi.DiscordCs.Core.Models.Collections;
using FarDragi.DiscordCs.Core.Models.Enumerators.Guild;
using FarDragi.DiscordCs.Core.Models.Enumerators.Role;
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
                },
                Config = new DiscordGuildConfig
                {
                    VerificationLevel = (DiscordGuildVerificationLevel)payload.Data.VerificationLevel,
                    DefaultMessageNotification = (DiscordGuildMessageNotificationLevel)payload.Data.DefaultMessageNotification,
                    ExplicitContentFilter = (DiscordGuildContentFilterLevel)payload.Data.ExplicitContentFilter
                },
                Roles = GetDiscordRoles(payload)
            };
        }

        internal DiscordRoleList GetDiscordRoles(PayloadRecived<EventGuildCreate> payload)
        {
            DiscordRoleList roles = new DiscordRoleList();

            for (int i = 0; i < payload.Data.Roles.Length; i++)
            {
                roles.Add(new DiscordRole
                {
                    Id = payload.Data.Roles[i].Id,
                    Name = payload.Data.Roles[i].Name,
                    Color = payload.Data.Roles[i].Color,
                    Position = payload.Data.Roles[i].Position,
                    Permissions = (DiscordRolePermissions)payload.Data.Roles[i].Permissions,
                    IsHoist = payload.Data.Roles[i].IsHoist,
                    IsManaged = payload.Data.Roles[i].IsManaged,
                    IsMentionable = payload.Data.Roles[i].IsMentionable
                });
            }

            return roles;
        }
    }
}
