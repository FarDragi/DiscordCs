using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entities.ChannelModels;
using FarDragi.DiscordCs.Entities.EmojiModels;
using FarDragi.DiscordCs.Entities.MemberModels;
using FarDragi.DiscordCs.Entities.PresenceModels;
using FarDragi.DiscordCs.Entities.RoleModels;
using FarDragi.DiscordCs.Entities.UserModels;
using FarDragi.DiscordCs.Entities.VoiceModels;
using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Entities.GuildModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#guild-object-guild-structure
    /// </summary>
    public class Guild
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("icon_hash")]
        public string IconHash { get; set; }

        [JsonProperty("splash")]
        public string Splash { get; set; }

        [JsonProperty("discovery_splash")]
        public string DiscoverySplash { get; set; }

        [JsonProperty("owner")]
        public bool Owner { get; set; }

        [JsonProperty("owner_id")]
        public ulong OwnerId { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("afk_channel_id")]
        public ulong? AfkChannelId { get; set; }

        [JsonProperty("afk_timeout")]
        public int AfkTimeout { get; set; }

        [JsonProperty("widget_enabled")]
        public bool WidgetEnabled { get; set; }

        [JsonProperty("widget_channel_id")]
        public ulong? WidgetChannelId { get; set; }

        [JsonProperty("verification_level")]
        public GuildVerificationLevel VerificationLevel { get; set; }

        [JsonProperty("default_message_notifications")]
        public GuildMessageNotificationLevel DefaultMessageNotifications { get; set; }

        [JsonProperty("explicit_content_filter")]
        public GuildExplicitContentFilterLevel ExplicitContentFilter { get; set; }

        [JsonProperty("roles")]
        private Role[] _roles { get; set; }

        [JsonProperty("emojis")]
        public Emoji[] Emojis { get; set; }

        [JsonProperty("features")]
        public string[] Features { get; set; }

        [JsonProperty("mfa_level")]
        public GuildMfaLevel MfaLevel { get; set; }

        [JsonProperty("application_id")]
        public ulong? ApplicationId { get; set; }

        [JsonProperty("system_channel_id")]
        public ulong SystemChannelId { get; set; }

        [JsonProperty("system_channel_flags")]
        public GuildSystemChannelFlags SystemChannelFlags { get; set; }

        [JsonProperty("rules_channel_id")]
        public ulong? RulesChannelId { get; set; }

        [JsonProperty("joined_at")]
        public DateTime? JoinedAt { get; set; }

        [JsonProperty("large")]
        public bool Large { get; set; }

        [JsonProperty("unavailable")]
        public bool Unavailable { get; set; }

        [JsonProperty("member_count")]
        public int MemberCount { get; set; }

        [JsonIgnore]
        public Voice[] Voices { get; set; }

        [JsonProperty("members")]
        private Member[] _members { get; set; }

        [JsonProperty("channels")]
        private BaseChannel[] _channels { get; set; }

        [JsonProperty("presences")]
        private Presence[] _presences { get; set; }

        [JsonProperty("max_presences")]
        public int? MaxPresences { get; set; }

        [JsonProperty("max_members")]
        public int? MaxMembers { get; set; }

        [JsonProperty("vanity_url_code")]
        public string VanityUrlCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("banner")]
        public string Banner { get; set; }

        [JsonProperty("premium_tier")]
        public GuildPremiumTier PremiumTier { get; set; }

        [JsonProperty("premium_subscription_count")]
        public int? PremiumSubscriptionCount { get; set; }

        [JsonProperty("preferred_locale")]
        public string PreferredLocale { get; set; }

        [JsonProperty("public_updates_channel_id")]
        public ulong? PublicUpdatesChannelId { get; set; }

        [JsonProperty("max_video_channel_users")]
        public int? MaxVideoChannelUsers { get; set; }

        [JsonProperty("approximate_member_count")]
        public int? ApproximateMemberCount { get; set; }

        [JsonProperty("approximate_presence_count")]
        public int? ApproximatePresenceCount { get; set; }

        public void InitCaching(ICacheConfig config)
        {
            Members = new MemberCollection(config.GetCache<Member>());
            Channels = new ChannelCollection(config.GetCache<Channel>());
            Roles = new RoleCollection(config.GetCache<Role>());
            Presences = new PresenceCollection(config.GetCache<Presence>());
        }

        public void MemberCache(UserCollection users)
        {
            if (_members != null)
            {
                for (int i = 0; i < _members.Length; i++)
                {
                    User user = _members[i].User;
                    users.Caching(ref user);
                    Members.Caching(ref _members[i]);
                }
            }
        }

        public void ChannelCache(ChannelCollection channels)
        {
            if (_channels != null)
            {
                for (int i = 0; i < _channels.Length; i++)
                {
                    Channel channel = null;

                    switch (_channels[i].Type)
                    {
                        case ChannelTypes.GuildText:
                            channel = (TextChannel)_channels[i];
                            break;
                        case ChannelTypes.GuildVoice:
                            channel = (VoiceChannel)_channels[i];
                            break;
                        case ChannelTypes.GuildCategory:
                            channel = (GuildCategory)_channels[i];
                            break;
                        case ChannelTypes.GuildNews:
                            channel = (GuildNews)_channels[i];
                            break;
                        case ChannelTypes.GuildStore:
                            channel = (GuildStore)_channels[i];
                            break;
                    }

                    channels.Caching(ref channel);
                    Channels.Caching(ref channel);
                }

                for (int i = 0; i < _channels.Length; i++)
                {
                    if (_channels[i].ParentId != null)
                    {
                        Channel channel = Channels[_channels[i].Id];
                        channel.Parent = (GuildCategory)Channels[(ulong)_channels[i].ParentId];
                    }
                }
            }
        }

        public void RoleCache()
        {
            if (_roles != null)
            {
                for (int i = 0; i < _roles.Length; i++)
                {
                    Roles.Caching(ref _roles[i]);
                }
            }
        }

        public void PresenceCache()
        {
            if (_presences != null)
            {
                for (int i = 0; i < _presences.Length; i++)
                {
                    Presences.Caching(ref _presences[i]);
                }
            }
        }

        [JsonIgnore]
        public MemberCollection Members { get; set; }

        [JsonIgnore]
        public ChannelCollection Channels { get; set; }

        [JsonIgnore]
        public RoleCollection Roles { get; set; }

        [JsonIgnore]
        public PresenceCollection Presences { get; set; }
    }
}
