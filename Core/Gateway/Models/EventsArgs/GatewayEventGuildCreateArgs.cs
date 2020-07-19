using FarDragi.DiscordCs.Core.Gateway.Models.Events;
using FarDragi.DiscordCs.Core.Gateway.Models.Payloads;
using FarDragi.DiscordCs.Core.Models.Base.Emoji;
using FarDragi.DiscordCs.Core.Models.Base.Guild;
using FarDragi.DiscordCs.Core.Models.Base.Member;
using FarDragi.DiscordCs.Core.Models.Base.Role;
using FarDragi.DiscordCs.Core.Models.Base.User;
using FarDragi.DiscordCs.Core.Models.Base.Voice;
using FarDragi.DiscordCs.Core.Models.Collections;
using FarDragi.DiscordCs.Core.Models.Enumerators.Guild;
using FarDragi.DiscordCs.Core.Models.Enumerators.Role;
using FarDragi.DiscordCs.Core.Models.Enumerators.User;
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
                ApplicationId = payload.Data.ApplicationId,
                RulesChannelId = payload.Data.RulesChannelId,
                JoinedAt = payload.Data.JoinedAt,
                IsLarge = payload.Data.IsLarge,
                MemberCount = payload.Data.MemberCount,
                VoicesStates = GetDiscordVoices(payload),
                Members = GetDiscordMembers(payload)
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

        internal DiscordVoiceList GetDiscordVoices(PayloadRecived<EventGuildCreate> payload)
        {
            DiscordVoiceList voices = new DiscordVoiceList();

            for (int i = 0; i < payload.Data.VoicesStates.Length; i++)
            {
                voices.Add(new DiscordVoice
                {
                    GuildId = payload.Data.VoicesStates[i].GuildId,
                    ChannelId = payload.Data.VoicesStates[i].ChannelId,
                    UserId = payload.Data.VoicesStates[i].UserId,
                    SessionId = payload.Data.VoicesStates[i].SessionId,
                    IsDeaf = payload.Data.VoicesStates[i].IsDeaf,
                    IsMute = payload.Data.VoicesStates[i].IsMute,
                    IsSeflDeaf = payload.Data.VoicesStates[i].IsSeflDeaf,
                    IsSelfMute = payload.Data.VoicesStates[i].IsSelfMute,
                    IsSelfStream = payload.Data.VoicesStates[i].IsSelfStream,
                    IsSeppress = payload.Data.VoicesStates[i].IsSeppress
                });
            }

            return voices;
        }

        internal DiscordMemberList GetDiscordMembers(PayloadRecived<EventGuildCreate> payload)
        {
            DiscordMemberList members = new DiscordMemberList();

            for (int i = 0; i < payload.Data.Members.Length; i++)
            {
                members.Add(new DiscordMember
                {
                    Nick = payload.Data.Members[i].Nick,
                    IsDeaf = payload.Data.Members[i].IsDeaf,
                    IsMute = payload.Data.Members[i].IsMute,
                    IsOwner = payload.Data.Members[i].User.Id == payload.Data.OwnerId,
                    JoinedAt = payload.Data.Members[i].JoinedAt,
                    PremiumSince = payload.Data.Members[i].PremiumSince,
                    Roles = payload.Data.Members[i].Roles,
                    User = new DiscordUser
                    {
                        Id = payload.Data.Members[i].User.Id,
                        Avatar = payload.Data.Members[i].User.Avatar,
                        Discriminator = payload.Data.Members[i].User.Discriminator,
                        Username = payload.Data.Members[i].User.Username,
                        Badges = (DiscordUserBadges)payload.Data.Members[i].User.Badges,
                        Email = payload.Data.Members[i].User.Email,
                        IsBot = payload.Data.Members[i].User.IsBot,
                        IsSystem = payload.Data.Members[i].User.IsSystem,
                        IsVerified = payload.Data.Members[i].User.IsVerified,
                        Locale = payload.Data.Members[i].User.Locale,
                        MfaEnabled = payload.Data.Members[i].User.MfaEnabled,
                        PremiumType = (DiscordUserPremiumType)payload.Data.Members[i].User.PremiumType
                    }
                });
            }

            return members;
        }
    }
}
