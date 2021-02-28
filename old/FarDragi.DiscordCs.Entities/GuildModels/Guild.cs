using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entities.ChannelModels;
using FarDragi.DiscordCs.Entities.EmojiModels;
using FarDragi.DiscordCs.Entities.MemberModels;
using FarDragi.DiscordCs.Entities.PresenceModels;
using FarDragi.DiscordCs.Entities.RoleModels;
using FarDragi.DiscordCs.Entities.UserModels;
using FarDragi.DiscordCs.Entities.VoiceModels;
using FarDragi.DiscordCs.Rest;
using System;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entities.GuildModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#guild-object-guild-structure
    /// </summary>
    public class Guild : ICacheInit
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("icon_hash")]
        public string IconHash { get; set; }

        [JsonPropertyName("splash")]
        public string Splash { get; set; }

        [JsonPropertyName("discovery_splash")]
        public string DiscoverySplash { get; set; }

        [JsonPropertyName("owner")]
        public bool Owner { get; set; }

        [JsonPropertyName("owner_id")]
        public ulong OwnerId { get; set; }

        [JsonPropertyName("permissions")]
        public string Permissions { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("afk_channel_id")]
        public ulong? AfkChannelId { get; set; }

        [JsonPropertyName("afk_timeout")]
        public int AfkTimeout { get; set; }

        [JsonPropertyName("widget_enabled")]
        public bool WidgetEnabled { get; set; }

        [JsonPropertyName("widget_channel_id")]
        public ulong? WidgetChannelId { get; set; }

        [JsonPropertyName("verification_level")]
        public GuildVerificationLevel VerificationLevel { get; set; }

        [JsonPropertyName("default_message_notifications")]
        public GuildMessageNotificationLevel DefaultMessageNotifications { get; set; }

        [JsonPropertyName("explicit_content_filter")]
        public GuildExplicitContentFilterLevel ExplicitContentFilter { get; set; }

        [JsonPropertyName("roles")]
        private Role[] _roles { get; set; }

        [JsonPropertyName("emojis")]
        public Emoji[] Emojis { get; set; }

        [JsonPropertyName("features")]
        public string[] Features { get; set; }

        [JsonPropertyName("mfa_level")]
        public GuildMfaLevel MfaLevel { get; set; }

        [JsonPropertyName("application_id")]
        public ulong? ApplicationId { get; set; }

        [JsonPropertyName("system_channel_id")]
        public ulong SystemChannelId { get; set; }

        [JsonPropertyName("system_channel_flags")]
        public GuildSystemChannelFlags SystemChannelFlags { get; set; }

        [JsonPropertyName("rules_channel_id")]
        public ulong? RulesChannelId { get; set; }

        [JsonPropertyName("joined_at")]
        public DateTime? JoinedAt { get; set; }

        [JsonPropertyName("large")]
        public bool Large { get; set; }

        [JsonPropertyName("unavailable")]
        public bool Unavailable { get; set; }

        [JsonPropertyName("member_count")]
        public int MemberCount { get; set; }

        [JsonIgnore]
        public Voice[] Voices { get; set; }

        [JsonPropertyName("members")]
        private Member[] _members { get; set; }

        [JsonPropertyName("channels")]
        private Channel[] _channels { get; set; }

        [JsonPropertyName("presences")]
        private Presence[] _presences { get; set; }

        [JsonPropertyName("max_presences")]
        public int? MaxPresences { get; set; }

        [JsonPropertyName("max_members")]
        public int? MaxMembers { get; set; }

        [JsonPropertyName("vanity_url_code")]
        public string VanityUrlCode { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("banner")]
        public string Banner { get; set; }

        [JsonPropertyName("premium_tier")]
        public GuildPremiumTier PremiumTier { get; set; }

        [JsonPropertyName("premium_subscription_count")]
        public int? PremiumSubscriptionCount { get; set; }

        [JsonPropertyName("preferred_locale")]
        public string PreferredLocale { get; set; }

        [JsonPropertyName("public_updates_channel_id")]
        public ulong? PublicUpdatesChannelId { get; set; }

        [JsonPropertyName("max_video_channel_users")]
        public int? MaxVideoChannelUsers { get; set; }

        [JsonPropertyName("approximate_member_count")]
        public int? ApproximateMemberCount { get; set; }

        [JsonPropertyName("approximate_presence_count")]
        public int? ApproximatePresenceCount { get; set; }

        public void InitCaching(ICacheConfig cacheConfig, RestClient rest)
        {
            Members = new MemberCollection(cacheConfig.GetCache<Member>());
            Channels = new ChannelCollection(cacheConfig.GetCache<Channel>());
            Roles = new RoleCollection(cacheConfig.GetCache<Role>());
            Presences = new PresenceCollection(cacheConfig.GetCache<Presence>());
        }

        public void MemberCache(UserCollection users)
        {
            if (_members != null)
            {
                for (int i = 0; i < _members.Length; i++)
                {
                    User user = _members[i].User;

                    if (user.Discriminator != null)
                    {
                        users.Caching(ref user);
                        Members.Caching(ref _members[i]);
                    }
                }
            }
        }

        public void ChannelCache(ICacheConfig cacheConfig, RestClient restClient, ChannelCollection channels)
        {
            if (_channels != null)
            {
                for (int i = 0; i < _channels.Length; i++)
                {
                    switch (_channels[i].Type)
                    {
                        case ChannelTypes.GuildNews:
                        case ChannelTypes.GuildStore:
                        case ChannelTypes.GuildText:
                            InitCaching((ICacheInit)_channels[i]);
                            break;
                        case ChannelTypes.GuildVoice:
                            break;
                        case ChannelTypes.GuildCategory:
                            break;
                    }

                    void InitCaching(ICacheInit cacheInit)
                    {
                        cacheInit.InitCaching(cacheConfig, restClient);
                    }

                    channels.Caching(ref _channels[i]);
                    Channels.Caching(ref _channels[i]);
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
