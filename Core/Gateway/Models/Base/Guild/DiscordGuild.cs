using FarDragi.DiscordCs.Core.Gateway.Models.Base.Emoji;
using FarDragi.DiscordCs.Core.Gateway.Models.Base.Member;
using FarDragi.DiscordCs.Core.Gateway.Models.Base.Role;
using FarDragi.DiscordCs.Core.Gateway.Models.Base.Voice;
using FarDragi.DiscordCs.Core.Gateway.Models.Enumerators;
using FarDragi.DiscordCs.Core.Gateway.Models.Enumerators.Guild;
using FarDragi.DiscordCs.Core.Gateway.Models.Enumerators.Role;
using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Guild
{
    internal class DiscordGuild
    {
        // Discord Guild
        [JsonProperty("id")]
        internal ulong Id { get; set; }

        // Discord Guild
        [JsonProperty("name")]
        internal string Name { get; set; }

        // Discord Guild
        [JsonProperty("icon")]
        internal string Icon { get; set; }

        // Discord Guild
        [JsonProperty("splash")]
        internal string Splash { get; set; }

        // Discord Guild
        [JsonProperty("discovery_splash")]
        internal string DiscoverySplash { get; set; }

        [JsonProperty("owner")]
        internal bool IsOwner { get; set; }

        // Discord Guild
        [JsonProperty("owner_id")]
        internal ulong OwnerId { get; set; }

        [JsonProperty("permissions")]
        internal DiscordRolePermissions Permissions { get; set; }

        // Discord Guild
        [JsonProperty("region")]
        internal string Region { get; set; }

        // Discord Guild Afk Config
        [JsonProperty("afk_channel_id")]
        internal ulong? AfkChannelId { get; set; }

        // Discord Guild Afk Config
        [JsonProperty("afk_timeout")]
        internal uint AfkTimeout { get; set; }

        // Discord Guild Embed Config
        [JsonProperty("embed_enabled")]
        internal bool EmbedEnabled { get; set; }

        // Discord Guild Embed Config
        [JsonProperty("embed_channel_id")]
        internal ulong? EmbedChannelId { get; set; }

        // Discord Guild Config
        [JsonProperty("verification_level")]
        internal DiscordGuildVerificationLevel VerificationLevel { get; set; }

        // Discord Guild Config
        [JsonProperty("default_message_notifications")]
        internal DiscordGuildMessageNotificationLevel DefaultMessageNotification { get; set; }

        // Discord Guild Config
        [JsonProperty("explicit_content_filter")]
        internal DiscordGuildContentFilterLevel ExplicitContentFilter { get; set; }

        // Discord Guild
        [JsonProperty("roles")]
        internal DiscordRole[] Roles { get; set; }

        // Discord Guild
        [JsonProperty("emojis")]
        internal DiscordEmoji[] Emojis { get; set; }

        // Discord Guild
        [JsonProperty("features")]
        internal string[] Features { get; set; }

        // Discord Guild
        [JsonProperty("mfa_level")]
        internal DiscordGuildMfaLevel MfaLevel { get; set; }

        // Discord Guild
        [JsonProperty("application_id")]
        internal ulong? ApplicationId { get; set; }

        // Discord Guild Widget Config
        [JsonProperty("widget_enabled")]
        internal bool WidgetEnabled { get; set; }

        // Discord Guild Widget Config
        [JsonProperty("widget_channel_id")]
        internal ulong? WidgetChannelId { get; set; }

        // Discord Guild System Config
        [JsonProperty("system_channel_id")]
        internal ulong? SystemChannelId { get; set; }

        // Discord Guild System Config
        [JsonProperty("system_channel_flags")]
        internal DiscordGuildSystemChannelFlags SystemChannelFlags { get; set; }

        // Discord Guild
        [JsonProperty("rules_channel_id")]
        internal ulong? RulesChannelId { get; set; }

        // Discord Guild
        [JsonProperty("joined_at")]
        internal DateTime JoinedAt { get; set; }

        // Discord Guild
        [JsonProperty("large")]
        internal bool IsLarge { get; set; }

        // Discord Guild
        [JsonProperty("unavailable")]
        internal bool IsUnavailable { get; set; }

        // Discord Guild
        [JsonProperty("member_count")]
        internal uint MemberCount { get; set; }

        // Discord Guild
        [JsonProperty("voice_states")]
        internal DiscordVoice[] VoicesStates { get; set; }

        // Discord Guild
        [JsonProperty("members")]
        internal DiscordMember[] Members { get; set; }

        [JsonProperty("channels")]
        internal DiscordChannel[] Channels { get; set; }

        [JsonProperty("presences")]
        internal DiscordPresence[] Presences { get; set; }

        [JsonProperty("max_presences")]
        internal uint? MaxPresences { get; set; }

        [JsonProperty("max_members")]
        internal uint MaxMembers { get; set; }

        [JsonProperty("vanity_url_code")]
        internal string VanityUrlCode { get; set; }

        // Discord Guild
        [JsonProperty("description")]
        internal string Description { get; set; }

        [JsonProperty("banner")]
        internal string Banner { get; set; }

        [JsonProperty("premium_tier")]
        internal DiscordPremiumTier PremiumTier { get; set; }

        [JsonProperty("premium_subscription_count")]
        internal uint PremiumSubscriptionCount { get; set; }

        [JsonProperty("preferred_locale")]
        internal string PreferredLocale { get; set; }

        [JsonProperty("public_updates_channel_id")]
        internal ulong? PublicUpdatesChannelId { get; set; }

        [JsonProperty("max_video_channel_users")]
        internal uint MaxVideoChannelUsers { get; set; }

        [JsonProperty("approximate_member_count")]
        internal uint ApproximateMemberCount { get; set; }

        [JsonProperty("approximate_presence_count")]
        internal uint ApproximatePresenceCount { get; set; }
    }
}
