using FarDragi.DiscordCs.Core.Gateway.Models.Events;
using FarDragi.DiscordCs.Core.Gateway.Models.Payloads;
using FarDragi.DiscordCs.Core.Models.Base.Emoji;
using FarDragi.DiscordCs.Core.Models.Base.Guild;
using FarDragi.DiscordCs.Core.Models.Base.Role;
using FarDragi.DiscordCs.Core.Models.Collections;
using FarDragi.DiscordCs.Core.Models.Enumerators.Guild;
using FarDragi.DiscordCs.Core.Models.Enumerators.Role;
using FarDragi.DiscordCs.Core.Models.Event;
using System;

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
                Config = new DiscordGuildConfig
                {
                    VerificationLevel = (DiscordGuildVerificationLevel)payload.Data.VerificationLevel,
                    DefaultMessageNotification = (DiscordGuildMessageNotificationLevel)payload.Data.DefaultMessageNotification,
                    ExplicitContentFilter = (DiscordGuildContentFilterLevel)payload.Data.ExplicitContentFilter,
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
                    WidgetConfig = new DiscordGuildWidgetConfig
                    {
                        WidgetChannelId = payload.Data.WidgetChannelId,
                        WidgetEnabled = payload.Data.WidgetEnabled
                    },
                    SystemConfig = new DiscordGuildSystemConfig
                    {
                        SystemChannelId = payload.Data.SystemChannelId,
                        SystemChannelFlags = (DiscordGuildSystemChannelFlags)payload.Data.SystemChannelFlags
                    }
                },
                Roles = GetDiscordRoles(payload),
                Emojis = GetDiscordEmojis(payload),
                Features = GetDiscordGuildFeatures(payload),
                MfaLevel = (DiscordGuildMfaLevel)payload.Data.MfaLevel,
                ApplicationId = payload.Data.ApplicationId
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

        internal DiscordEmojiList GetDiscordEmojis(PayloadRecived<EventGuildCreate> payload)
        {
            DiscordEmojiList emojis = new DiscordEmojiList();

            for (int i = 0; i < payload.Data.Emojis.Length; i++)
            {
                emojis.Add(new DiscordEmoji
                {
                    Id = payload.Data.Emojis[i].Id,
                    Name = payload.Data.Emojis[i].Name,
                    Roles = payload.Data.Emojis[i].Roles,
                    RequireColons = payload.Data.Emojis[i].RequireColons,
                    IsAnimated = payload.Data.Emojis[i].IsAnimated,
                    IsAvailable = payload.Data.Emojis[i].IsAvailable,
                    IsManaged = payload.Data.Emojis[i].IsManaged
                });
            }

            return emojis;
        }

        internal DiscordGuildFeatures GetDiscordGuildFeatures(PayloadRecived<EventGuildCreate> payload)
        {
            if (payload.Data.Features.Length == 0) return DiscordGuildFeatures.None;

            DiscordGuildFeatures features = DiscordGuildFeatures.None;

            for (int i = 0; i < payload.Data.Features.Length; i++)
            {
                char[] feature = payload.Data.Features[i].ToCharArray();

                string convert = "";
                convert += feature[0];

                for (int j = 1; j < feature.Length; j++)
                {
                    if (feature[j] == '_')
                    {
                        convert += feature[++j];
                        continue;
                    }

                    convert += char.ToLower(feature[j]);
                }

                if (Enum.TryParse(typeof(DiscordGuildFeatures), convert, out object result))
                {
                    features |= (DiscordGuildFeatures)result;
                }
            }

            return features;
        }
    }
}
