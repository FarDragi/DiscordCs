using FarDragi.DiscordCs.Core.Gateway.Models.Events;
using FarDragi.DiscordCs.Core.Gateway.Models.Payloads;
using FarDragi.DiscordCs.Core.Models.Base.Channel;
using FarDragi.DiscordCs.Core.Models.Base.Embed;
using FarDragi.DiscordCs.Core.Models.Base.Emoji;
using FarDragi.DiscordCs.Core.Models.Base.Guild;
using FarDragi.DiscordCs.Core.Models.Base.Member;
using FarDragi.DiscordCs.Core.Models.Base.Message;
using FarDragi.DiscordCs.Core.Models.Base.Role;
using FarDragi.DiscordCs.Core.Models.Base.User;
using FarDragi.DiscordCs.Core.Models.Collections;
using FarDragi.DiscordCs.Core.Models.Enums.Channel;
using FarDragi.DiscordCs.Core.Models.Enums.Message;
using FarDragi.DiscordCs.Core.Models.Enums.Role;
using FarDragi.DiscordCs.Core.Models.Enums.User;
using FarDragi.DiscordCs.Core.Models.Event;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Core.Gateway.Models.EventsArgs
{
    internal class GatewayEventMessageCreateArgs
    {
        internal MessageCreate Data { get; private set; }

        internal async Task<GatewayEventMessageCreateArgs> DataConverter(PayloadRecived<EventMessageCreate> payload)
        {
            Task<DiscordUserMentionList> userMentions = GetUserMentions(payload);
            Task<DiscordRoleList> roleMentions = GetRolesMentions(payload);
            Task<DiscordGuildChannels> channelsMentions = GetDiscordGuildChannelsMentions(payload);
            Task<DiscordMessageAttachmentList> attachments = GetMessageAttachments(payload);
            Task<DiscordEmbedList> embeds = GetEmbeds(payload);
            Task<DiscordMessageReactionList> reactions = GetReactions(payload);

            DiscordUser user = new DiscordUser
            {
                Id = payload.Data.Author.Id,
                Avatar = payload.Data.Author.Avatar,
                Badges = (DiscordUserBadges)payload.Data.Author.Badges,
                Discriminator = payload.Data.Author.Discriminator,
                Email = payload.Data.Author.Email,
                IsBot = payload.Data.Author.IsBot,
                IsSystem = payload.Data.Author.IsSystem,
                IsVerified = payload.Data.Author.IsVerified,
                Locale = payload.Data.Author.Locale,
                MfaEnabled = payload.Data.Author.MfaEnabled,
                PremiumType = (DiscordUserPremiumType)payload.Data.Author.PremiumType,
                Username = payload.Data.Author.Username
            };

            Data = new MessageCreate
            {
                Id = payload.Data.Id,
                ChannelId = payload.Data.ChannelId,
                GuildId = payload.Data.GuildId,
                Author = user,
                Member = new DiscordMember
                {
                    User = user,
                    IsDeaf = payload.Data.Member.IsDeaf,
                    IsMute = payload.Data.Member.IsMute,
                    JoinedAt = payload.Data.Member.JoinedAt,
                    Nick = payload.Data.Member.Nick,
                    PremiumSince = payload.Data.Member.PremiumSince,
                    Roles = payload.Data.Member.Roles
                },
                Content = payload.Data.Content,
                Timestamp = payload.Data.Timestamp,
                EditedTimestamp = payload.Data.EditedTimestamp,
                IsTts = payload.Data.IsTts,
                IsMentionEveryone = payload.Data.IsMentionEveryone,
                Nonce = payload.Data.Nonce,
                IsPinned = payload.Data.IsPinned,
                WebhookId = payload.Data.WebhookId,
                MessageType = (DiscordMessageType)payload.Data.MessageType,
                MessageFlags = (DiscordMessageFlags)payload.Data.MessageFlags
            };

            if (payload.Data.Activity != null)
            {
                Data.Activity = new DiscordMessageActivity
                {
                    PartyId = payload.Data.Activity.PartyId,
                    Type = (DiscordMessageActivityType)payload.Data.Activity.Type
                };
            }

            if (payload.Data.Application != null)
            {
                Data.Application = new DiscordMessageApplication
                {
                    Id = payload.Data.Application.Id,
                    CoverImage = payload.Data.Application.CoverImage,
                    Description = payload.Data.Application.Description,
                    Icon = payload.Data.Application.Icon,
                    Name = payload.Data.Application.Name
                };
            }

            if (payload.Data.Reference != null)
            {
                Data.Reference = new DiscordMessageReference
                {
                    ChannelId = payload.Data.Reference.ChannelId,
                    GuildId = payload.Data.Reference.GuildId,
                    MessageId = payload.Data.Reference.MessageId
                };
            }

            Data.UserMentions = await userMentions;
            Data.RolesMentions = await roleMentions;
            Data.ChannelsMentions = await channelsMentions;
            Data.Attachments = await attachments;
            Data.Embeds = await embeds;
            Data.Reactions = await reactions;

            return this;
        }

        private Task<DiscordUserMentionList> GetUserMentions(PayloadRecived<EventMessageCreate> payload)
        {
            DiscordUserMentionList mentions = new DiscordUserMentionList();

            for (int i = 0; i < payload.Data.UserMentions.Length; i++)
            {
                DiscordUserMention user = (DiscordUserMention)new DiscordUser
                {
                    Id = payload.Data.UserMentions[i].Id,
                    Avatar = payload.Data.UserMentions[i].Avatar,
                    Badges = (DiscordUserBadges)payload.Data.UserMentions[i].Badges,
                    Discriminator = payload.Data.UserMentions[i].Discriminator,
                    Email = payload.Data.UserMentions[i].Email,
                    IsBot = payload.Data.UserMentions[i].IsBot,
                    IsSystem = payload.Data.UserMentions[i].IsSystem,
                    IsVerified = payload.Data.UserMentions[i].IsVerified,
                    Locale = payload.Data.UserMentions[i].Locale,
                    MfaEnabled = payload.Data.UserMentions[i].MfaEnabled,
                    PremiumType = (DiscordUserPremiumType)payload.Data.UserMentions[i].PremiumType,
                    Username = payload.Data.UserMentions[i].Username
                };

                user.Member = new DiscordMember
                {
                    User = user,
                    IsDeaf = payload.Data.UserMentions[i].Member.IsDeaf,
                    IsMute = payload.Data.UserMentions[i].Member.IsMute,
                    JoinedAt = payload.Data.UserMentions[i].Member.JoinedAt,
                    Nick = payload.Data.UserMentions[i].Member.Nick,
                    PremiumSince = payload.Data.UserMentions[i].Member.PremiumSince,
                    Roles = payload.Data.UserMentions[i].Member.Roles
                };

                mentions.Add(user);
            }

            return Task.FromResult(mentions);
        }

        private Task<DiscordRoleList> GetRolesMentions(PayloadRecived<EventMessageCreate> payload)
        {
            DiscordRoleList mentions = new DiscordRoleList();

            for (int i = 0; i < payload.Data.MentionRoles.Length; i++)
            {
                mentions.Add(new DiscordRole
                {
                    Id = payload.Data.MentionRoles[i].Id,
                    Color = payload.Data.MentionRoles[i].Color,
                    IsHoist = payload.Data.MentionRoles[i].IsHoist,
                    IsManaged = payload.Data.MentionRoles[i].IsManaged,
                    IsMentionable = payload.Data.MentionRoles[i].IsMentionable,
                    Name = payload.Data.MentionRoles[i].Name,
                    Permissions = (DiscordRolePermissions)payload.Data.MentionRoles[i].Permissions,
                    Position = payload.Data.MentionRoles[i].Position
                });
            }

            return Task.FromResult(mentions);
        }

        private Task<DiscordGuildChannels> GetDiscordGuildChannelsMentions(PayloadRecived<EventMessageCreate> payload)
        {
            DiscordCategoryChannelList categoryChannels = new DiscordCategoryChannelList();
            DiscordTextChannelList textChannels = new DiscordTextChannelList();
            DiscordVoiceChannelList voiceChannels = new DiscordVoiceChannelList();

            if (payload.Data.MentionChannels == null)
            {
                return Task.FromResult(new DiscordGuildChannels
                {
                    CategoryChannels = categoryChannels,
                    TextChannels = textChannels,
                    VoiceChannels = voiceChannels
                });
            }

            for (int i = 0; i < payload.Data.MentionChannels.Length; i++)
            {
                if (payload.Data.MentionChannels[i].Type == Enums.Channel.DiscordChannelType.GuildCategory)
                {
                    DiscordCategoryChannel categoryChannel = new DiscordCategoryChannel
                    {
                        Id = payload.Data.MentionChannels[i].Id,
                        GuildId = payload.Data.MentionChannels[i].GuildId,
                        Name = payload.Data.MentionChannels[i].Name,
                        ParentId = payload.Data.MentionChannels[i].ParentId,
                        Position = payload.Data.MentionChannels[i].Position,
                        Type = (DiscordChannelType)payload.Data.MentionChannels[i].Type,
                        Overrites = new DiscordChannelOverritesList()
                    };

                    for (int j = 0; j < payload.Data.MentionChannels[i].PermissionOverwrites.Length; j++)
                    {
                        DiscordChannelOverrites overrites = new DiscordChannelOverrites
                        {
                            Id = payload.Data.MentionChannels[i].PermissionOverwrites[j].Id,
                            Allow = (DiscordRolePermissions)payload.Data.MentionChannels[i].PermissionOverwrites[j].Allow,
                            Deny = (DiscordRolePermissions)payload.Data.MentionChannels[i].PermissionOverwrites[j].Deny,
                            Type = payload.Data.MentionChannels[i].PermissionOverwrites[j].Type == "role" ? DiscordChannelOverritesType.Role : DiscordChannelOverritesType.Member
                        };

                        categoryChannel.Overrites.Add(overrites);
                    }

                    categoryChannels.Add(categoryChannel);
                }
                else if (payload.Data.MentionChannels[i].Type == Enums.Channel.DiscordChannelType.GuildText)
                {
                    DiscordTextChannel textChannel = new DiscordTextChannel
                    {
                        Id = payload.Data.MentionChannels[i].Id,
                        GuildId = payload.Data.MentionChannels[i].GuildId,
                        Name = payload.Data.MentionChannels[i].Name,
                        ParentId = payload.Data.MentionChannels[i].ParentId,
                        Position = payload.Data.MentionChannels[i].Position,
                        Type = (DiscordChannelType)payload.Data.MentionChannels[i].Type,
                        IsNsfw = payload.Data.MentionChannels[i].IsNsfw,
                        LastMessageId = payload.Data.MentionChannels[i].LastMessageId,
                        RateLimitPerUser = payload.Data.MentionChannels[i].RateLimitPerUser,
                        Topic = payload.Data.MentionChannels[i].Topic,
                        Overrites = new DiscordChannelOverritesList()
                    };

                    for (int j = 0; j < payload.Data.MentionChannels[i].PermissionOverwrites.Length; j++)
                    {
                        DiscordChannelOverrites overrites = new DiscordChannelOverrites
                        {
                            Id = payload.Data.MentionChannels[i].PermissionOverwrites[j].Id,
                            Allow = (DiscordRolePermissions)payload.Data.MentionChannels[i].PermissionOverwrites[j].Allow,
                            Deny = (DiscordRolePermissions)payload.Data.MentionChannels[i].PermissionOverwrites[j].Deny,
                            Type = payload.Data.MentionChannels[i].PermissionOverwrites[j].Type == "role" ? DiscordChannelOverritesType.Role : DiscordChannelOverritesType.Member
                        };

                        textChannel.Overrites.Add(overrites);
                    }

                    textChannels.Add(textChannel);
                }
                else if (payload.Data.MentionChannels[i].Type == Enums.Channel.DiscordChannelType.GuildVoice)
                {
                    DiscordVoiceChannel voiceChannel = new DiscordVoiceChannel
                    {
                        Id = payload.Data.MentionChannels[i].Id,
                        GuildId = payload.Data.MentionChannels[i].GuildId,
                        Name = payload.Data.MentionChannels[i].Name,
                        ParentId = payload.Data.MentionChannels[i].ParentId,
                        Position = payload.Data.MentionChannels[i].Position,
                        Type = (DiscordChannelType)payload.Data.MentionChannels[i].Type,
                        Bitrate = payload.Data.MentionChannels[i].Bitrate,
                        UserLimit = payload.Data.MentionChannels[i].UserLimit,
                        Overrites = new DiscordChannelOverritesList()
                    };

                    for (int j = 0; j < payload.Data.MentionChannels[i].PermissionOverwrites.Length; j++)
                    {
                        DiscordChannelOverrites overrites = new DiscordChannelOverrites
                        {
                            Id = payload.Data.MentionChannels[i].PermissionOverwrites[j].Id,
                            Allow = (DiscordRolePermissions)payload.Data.MentionChannels[i].PermissionOverwrites[j].Allow,
                            Deny = (DiscordRolePermissions)payload.Data.MentionChannels[i].PermissionOverwrites[j].Deny,
                            Type = payload.Data.MentionChannels[i].PermissionOverwrites[j].Type == "role" ? DiscordChannelOverritesType.Role : DiscordChannelOverritesType.Member
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

        private Task<DiscordMessageAttachmentList> GetMessageAttachments(PayloadRecived<EventMessageCreate> payload)
        {
            DiscordMessageAttachmentList attachments = new DiscordMessageAttachmentList();

            for (int i = 0; i < payload.Data.Attachments.Length; i++)
            {
                attachments.Add(new DiscordMessageAttachment
                {
                    Id = payload.Data.Attachments[i].Id,
                    Filename = payload.Data.Attachments[i].Filename,
                    Height = payload.Data.Attachments[i].Height,
                    ProxyUrl = payload.Data.Attachments[i].ProxyUrl,
                    Size = payload.Data.Attachments[i].Size,
                    Url = payload.Data.Attachments[i].Url,
                    Width = payload.Data.Attachments[i].Width
                });
            }

            return Task.FromResult(attachments);
        }

        private async Task<DiscordEmbedList> GetEmbeds(PayloadRecived<EventMessageCreate> payload)
        {
            DiscordEmbedList embeds = new DiscordEmbedList();

            for (int i = 0; i < payload.Data.Embeds.Length; i++)
            {
                Task<DiscordFieldList> fields = GetFields(payload, i);

                embeds.Add(new DiscordEmbed
                {
                    Author = new DiscordAuthor
                    {
                        IconUrl = payload.Data.Embeds[i].Author.IconUrl,
                        Name = payload.Data.Embeds[i].Author.Name,
                        ProxyIconUrl = payload.Data.Embeds[i].Author.ProxyIconUrl,
                        Url = payload.Data.Embeds[i].Author.Url
                    },
                    Color = payload.Data.Embeds[i].Color,
                    Description = payload.Data.Embeds[i].Description,
                    Timestamp = payload.Data.Embeds[i].Timestamp,
                    Title = payload.Data.Embeds[i].Title,
                    Type = payload.Data.Embeds[i].Type,
                    Url = payload.Data.Embeds[i].Url,
                    Footer = new DiscordFooter
                    {
                        IconUrl = payload.Data.Embeds[i].Footer.IconUrl,
                        Text = payload.Data.Embeds[i].Footer.Text
                    },
                    Image = new DiscordImage
                    {
                        Height = payload.Data.Embeds[i].Image.Height,
                        ProxyUrl = payload.Data.Embeds[i].Image.ProxyUrl,
                        Url = payload.Data.Embeds[i].Image.Url,
                        Width = payload.Data.Embeds[i].Image.Width
                    },
                    Provider = new DiscordProvider
                    {
                        Url = payload.Data.Embeds[i].Provider.Url,
                        Name = payload.Data.Embeds[i].Provider.Name
                    },
                    Thumbnail = new DiscordThumbnail
                    {
                        Height = payload.Data.Embeds[i].Thumbnail.Height,
                        Url = payload.Data.Embeds[i].Thumbnail.Url,
                        Width = payload.Data.Embeds[i].Thumbnail.Width,
                        ProxyUrl = payload.Data.Embeds[i].Thumbnail.ProxyUrl
                    },
                    Video = new DiscordVideo
                    {
                        Width = payload.Data.Embeds[i].Video.Width,
                        Url = payload.Data.Embeds[i].Video.Url,
                        Height = payload.Data.Embeds[i].Video.Height
                    },
                    Fields = await fields
                });
            }

            // TODO converter o embed sem dar erro

            return embeds;
        }

        private Task<DiscordFieldList> GetFields(PayloadRecived<EventMessageCreate> payload, int embedId)
        {
            DiscordFieldList fields = new DiscordFieldList();

            for (int i = 0; i < payload.Data.Embeds[embedId].Fields.Length; i++)
            {
                fields.Add(new DiscordField
                {
                    Name = payload.Data.Embeds[embedId].Fields[i].Name,
                    IsInline = payload.Data.Embeds[embedId].Fields[i].IsInline,
                    Value = payload.Data.Embeds[embedId].Fields[i].Value
                });
            }

            return Task.FromResult(fields);
        }

        private Task<DiscordMessageReactionList> GetReactions(PayloadRecived<EventMessageCreate> payload)
        {
            if (payload.Data.Reactions == null) return Task.FromResult(new DiscordMessageReactionList());

            DiscordMessageReactionList reactions = new DiscordMessageReactionList();

            for (int i = 0; i < payload.Data.Reactions.Length; i++)
            {
                reactions.Add(new DiscordMessageReaction
                {
                    Count = payload.Data.Reactions[i].Count,
                    Emoji = new DiscordEmoji
                    {
                        Id = payload.Data.Reactions[i].Emoji.Id,
                        IsAnimated = payload.Data.Reactions[i].Emoji.IsAnimated,
                        IsAvailable = payload.Data.Reactions[i].Emoji.IsAvailable,
                        IsManaged = payload.Data.Reactions[i].Emoji.IsManaged,
                        Name = payload.Data.Reactions[i].Emoji.Name,
                        RequireColons = payload.Data.Reactions[i].Emoji.RequireColons,
                        Roles = payload.Data.Reactions[i].Emoji.Roles,
                        User = new DiscordUser
                        {
                            Id = payload.Data.Reactions[i].Emoji.User.Id,
                            Avatar = payload.Data.Reactions[i].Emoji.User.Avatar,
                            Badges = (DiscordUserBadges)payload.Data.Reactions[i].Emoji.User.Badges,
                            Discriminator = payload.Data.Reactions[i].Emoji.User.Discriminator,
                            Email = payload.Data.Reactions[i].Emoji.User.Email,
                            IsBot = payload.Data.Reactions[i].Emoji.User.IsBot,
                            IsSystem = payload.Data.Reactions[i].Emoji.User.IsSystem,
                            IsVerified = payload.Data.Reactions[i].Emoji.User.IsVerified,
                            Locale = payload.Data.Reactions[i].Emoji.User.Locale,
                            MfaEnabled = payload.Data.Reactions[i].Emoji.User.MfaEnabled,
                            PremiumType = (DiscordUserPremiumType)payload.Data.Reactions[i].Emoji.User.PremiumType,
                            Username = payload.Data.Reactions[i].Emoji.User.Username
                        }
                    },
                    IsMe = payload.Data.Reactions[i].IsMe
                });
            }

            return Task.FromResult(reactions);
        }
    }
}
