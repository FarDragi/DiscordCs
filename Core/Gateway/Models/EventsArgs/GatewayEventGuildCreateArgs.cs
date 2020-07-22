using FarDragi.DiscordCs.Core.Gateway.Models.Events;
using FarDragi.DiscordCs.Core.Gateway.Models.Payloads;
using FarDragi.DiscordCs.Core.Models.Base.Channel;
using FarDragi.DiscordCs.Core.Models.Base.Emoji;
using FarDragi.DiscordCs.Core.Models.Base.Guild;
using FarDragi.DiscordCs.Core.Models.Base.Member;
using FarDragi.DiscordCs.Core.Models.Base.Presence;
using FarDragi.DiscordCs.Core.Models.Base.Role;
using FarDragi.DiscordCs.Core.Models.Base.User;
using FarDragi.DiscordCs.Core.Models.Base.Voice;
using FarDragi.DiscordCs.Core.Models.Collections;
using FarDragi.DiscordCs.Core.Models.Enums.Channel;
using FarDragi.DiscordCs.Core.Models.Enums.Guild;
using FarDragi.DiscordCs.Core.Models.Enums.Role;
using FarDragi.DiscordCs.Core.Models.Enums.User;
using FarDragi.DiscordCs.Core.Models.Event;
using System;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Core.Gateway.Models.EventsArgs
{
    internal class GatewayEventGuildCreateArgs
    {
        internal GuildCreate Data { get; private set; }

        internal async Task<GatewayEventGuildCreateArgs> DataConvert(PayloadRecived<EventGuildCreate> payload)
        {
            Task<DiscordRoleList> rolesTask = GetDiscordRoles(payload);
            Task<DiscordEmojiList> emojisTask = GetDiscordEmojis(payload);
            Task<DiscordGuildFeatures> featuresTask = GetDiscordGuildFeatures(payload);
            Task<DiscordVoiceList> voicesTask = GetDiscordVoices(payload);
            Task<DiscordMemberList> membersTask = GetDiscordMembers(payload);
            Task<DiscordGuildChannels> channelsTask = GetDiscordGuildChannels(payload);
            Task<DiscordPresenceList> presenceTask = GetDiscordPresences(payload);

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
                MfaLevel = (DiscordGuildMfaLevel)payload.Data.MfaLevel,
                ApplicationId = payload.Data.ApplicationId,
                RulesChannelId = payload.Data.RulesChannelId,
                JoinedAt = payload.Data.JoinedAt,
                IsLarge = payload.Data.IsLarge,
                MemberCount = payload.Data.MemberCount,
                Banner = payload.Data.Banner,
                ApproximateMemberCount = payload.Data.ApproximateMemberCount,
                ApproximatePresenceCount = payload.Data.ApproximatePresenceCount,
                MaxMembers = payload.Data.MaxMembers,
                MaxPresences = payload.Data.MaxPresences,
                MaxVideoChannelUsers = payload.Data.MaxVideoChannelUsers,
                PreferredLocale = payload.Data.PreferredLocale,
                PremiumSubscriptionCount = payload.Data.PremiumSubscriptionCount,
                PremiumTier = (DiscordGuildPremiumTier)payload.Data.PremiumTier,
                PublicUpdatesChannelId = payload.Data.PublicUpdatesChannelId,
                VanityUrlCode = payload.Data.VanityUrlCode,
                Roles = await rolesTask,
                Emojis = await emojisTask,
                Features = await featuresTask,
                VoicesStates = await voicesTask,
                Members = await membersTask,
                Channels = await channelsTask,
                Presences = await presenceTask
            };

            return this;
        }

        private Task<DiscordRoleList> GetDiscordRoles(PayloadRecived<EventGuildCreate> payload)
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

            return Task.FromResult(roles);
        }

        private Task<DiscordEmojiList> GetDiscordEmojis(PayloadRecived<EventGuildCreate> payload)
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

            return Task.FromResult(emojis);
        }

        private Task<DiscordGuildFeatures> GetDiscordGuildFeatures(PayloadRecived<EventGuildCreate> payload)
        {
            if (payload.Data.Features.Length == 0) return Task.FromResult(DiscordGuildFeatures.None);

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

            return Task.FromResult(features);
        }

        private Task<DiscordVoiceList> GetDiscordVoices(PayloadRecived<EventGuildCreate> payload)
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
                    IsSelfDeaf = payload.Data.VoicesStates[i].IsSelfDeaf,
                    IsSelfMute = payload.Data.VoicesStates[i].IsSelfMute,
                    IsSelfStream = payload.Data.VoicesStates[i].IsSelfStream,
                    IsSuppress = payload.Data.VoicesStates[i].IsSuppress
                });
            }

            return Task.FromResult(voices);
        }

        private Task<DiscordMemberList> GetDiscordMembers(PayloadRecived<EventGuildCreate> payload)
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

            return Task.FromResult(members);
        }

        private Task<DiscordGuildChannels> GetDiscordGuildChannels(PayloadRecived<EventGuildCreate> payload)
        {
            DiscordCategoryChannelList categoryChannels = new DiscordCategoryChannelList();
            DiscordTextChannelList textChannels = new DiscordTextChannelList();
            DiscordVoiceChannelList voiceChannels = new DiscordVoiceChannelList();

            for (int i = 0; i < payload.Data.Channels.Length; i++)
            {
                if (payload.Data.Channels[i].Type == Enums.Channel.DiscordChannelType.GuildCategory)
                {
                    DiscordCategoryChannel categoryChannel = new DiscordCategoryChannel
                    {
                        Id = payload.Data.Channels[i].Id,
                        GuildId = payload.Data.Id,
                        Name = payload.Data.Channels[i].Name,
                        ParentId = payload.Data.Channels[i].ParentId,
                        Position = payload.Data.Channels[i].Position,
                        Type = (DiscordChannelType)payload.Data.Channels[i].Type,
                        Overrites = new DiscordChannelOverritesList()
                    };

                    for (int j = 0; j < payload.Data.Channels[i].PermissionOverwrites.Length; j++)
                    {
                        DiscordChannelOverrites overrites = new DiscordChannelOverrites
                        {
                            Id = payload.Data.Channels[i].PermissionOverwrites[j].Id,
                            Allow = (DiscordRolePermissions)payload.Data.Channels[i].PermissionOverwrites[j].Allow,
                            Deny = (DiscordRolePermissions)payload.Data.Channels[i].PermissionOverwrites[j].Deny,
                            Type = payload.Data.Channels[i].PermissionOverwrites[j].Type == "role" ? DiscordChannelOverritesType.Role : DiscordChannelOverritesType.Member
                        };

                        categoryChannel.Overrites.Add(overrites);
                    }

                    categoryChannels.Add(categoryChannel);
                }
                else if (payload.Data.Channels[i].Type == Enums.Channel.DiscordChannelType.GuildText)
                {
                    DiscordTextChannel textChannel = new DiscordTextChannel
                    {
                        Id = payload.Data.Channels[i].Id,
                        GuildId = payload.Data.Id,
                        Name = payload.Data.Channels[i].Name,
                        ParentId = payload.Data.Channels[i].ParentId,
                        Position = payload.Data.Channels[i].Position,
                        Type = (DiscordChannelType)payload.Data.Channels[i].Type,
                        IsNsfw = payload.Data.Channels[i].IsNsfw,
                        LastMessageId = payload.Data.Channels[i].LastMessageId,
                        RateLimitPerUser = payload.Data.Channels[i].RateLimitPerUser,
                        Topic = payload.Data.Channels[i].Topic,
                        Overrites = new DiscordChannelOverritesList()
                    };

                    for (int j = 0; j < payload.Data.Channels[i].PermissionOverwrites.Length; j++)
                    {
                        DiscordChannelOverrites overrites = new DiscordChannelOverrites
                        {
                            Id = payload.Data.Channels[i].PermissionOverwrites[j].Id,
                            Allow = (DiscordRolePermissions)payload.Data.Channels[i].PermissionOverwrites[j].Allow,
                            Deny = (DiscordRolePermissions)payload.Data.Channels[i].PermissionOverwrites[j].Deny,
                            Type = payload.Data.Channels[i].PermissionOverwrites[j].Type == "role" ? DiscordChannelOverritesType.Role : DiscordChannelOverritesType.Member
                        };

                        textChannel.Overrites.Add(overrites);
                    }

                    textChannels.Add(textChannel);
                }
                else if (payload.Data.Channels[i].Type == Enums.Channel.DiscordChannelType.GuildVoice)
                {
                    DiscordVoiceChannel voiceChannel = new DiscordVoiceChannel
                    {
                        Id = payload.Data.Channels[i].Id,
                        GuildId = payload.Data.Id,
                        Name = payload.Data.Channels[i].Name,
                        ParentId = payload.Data.Channels[i].ParentId,
                        Position = payload.Data.Channels[i].Position,
                        Type = (DiscordChannelType)payload.Data.Channels[i].Type,
                        Bitrate = payload.Data.Channels[i].Bitrate,
                        UserLimit = payload.Data.Channels[i].UserLimit,
                        Overrites = new DiscordChannelOverritesList()
                    };

                    for (int j = 0; j < payload.Data.Channels[i].PermissionOverwrites.Length; j++)
                    {
                        DiscordChannelOverrites overrites = new DiscordChannelOverrites
                        {
                            Id = payload.Data.Channels[i].PermissionOverwrites[j].Id,
                            Allow = (DiscordRolePermissions)payload.Data.Channels[i].PermissionOverwrites[j].Allow,
                            Deny = (DiscordRolePermissions)payload.Data.Channels[i].PermissionOverwrites[j].Deny,
                            Type = payload.Data.Channels[i].PermissionOverwrites[j].Type == "role" ? DiscordChannelOverritesType.Role : DiscordChannelOverritesType.Member
                        };

                        voiceChannel.Overrites.Add(overrites);
                    }

                    voiceChannels.Add(voiceChannel);
                }
            }

            return Task.FromResult(new DiscordGuildChannels
            {
                CategoryChannels = categoryChannels,
                TextChannels = textChannels,
                VoiceChannels = voiceChannels
            });
        }

        private Task<DiscordPresenceList> GetDiscordPresences(PayloadRecived<EventGuildCreate> payload)
        {
            DiscordPresenceList presences = new DiscordPresenceList();

            for (int i = 0; i < payload.Data.Presences.Length; i++)
            {
                presences.Add(new DiscordPresence
                {
                    Nick = payload.Data.Presences[i].Nick,
                    GuildId = payload.Data.Presences[i].GuildId,
                    Roles = payload.Data.Presences[i].Roles,
                    Status = payload.Data.Presences[i].Status,
                    PremiumSince = payload.Data.Presences[i].PremiumSince
                });
            }

            return Task.FromResult(presences);
        }
    }
}
