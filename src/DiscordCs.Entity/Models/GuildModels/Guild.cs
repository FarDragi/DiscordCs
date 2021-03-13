using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using FarDragi.DiscordCs.Entity.Models.EmojiModels;
using FarDragi.DiscordCs.Entity.Models.MemberModels;
using FarDragi.DiscordCs.Entity.Models.PresenceModels;
using FarDragi.DiscordCs.Entity.Models.RoleModels;
using FarDragi.DiscordCs.Entity.Models.VoiceModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.GuildModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#guild-object-guild-structure
    /// </summary>
    public class Guild
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
        public bool IsOwner { get; set; }

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
        public bool IsWidgetEnabled { get; set; }

        [JsonPropertyName("widget_channel_id")]
        public ulong? WidgetChannelId { get; set; }

        [JsonPropertyName("verification_level")]
        public GuildVerificationLevel VerificationLevel { get; set; }

        [JsonPropertyName("default_message_notifications")]
        public GuildMessageNotificationLevel DefaultMessageNotifications { get; set; }

        [JsonPropertyName("explicit_content_filter")]
        public GuildExplicitContentFilterLevel ExplicitContentFilter { get; set; }

        [JsonPropertyName("roles")]
        public Role[] Roles { get; set; }

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
        public bool IsLarge { get; set; }

        [JsonPropertyName("unavailable")]
        public bool IsUnavailable { get; set; }

        [JsonPropertyName("member_count")]
        public int MemberCount { get; set; }

        [JsonPropertyName("voices")]
        public Voice[] Voices { get; set; }

        [JsonPropertyName("members")]
        public MemberCollection Members { get; set; }

        [JsonPropertyName("channels")]
        public GuildChannelsCollection Channels { get; set; }

        [JsonPropertyName("presences")]
        public Presence[] Presences { get; set; }

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
    }
}
