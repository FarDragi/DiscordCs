using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DragiCordApi.Core.Models
{
    public class DiscordGuild
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("splash")]
        public string Splash { get; set; }
        [JsonProperty("discovery_splash")]
        public string DiscoverySplash { get; set; }
        [JsonProperty("owner")]
        public bool IsOwner { get; set; }
        [JsonProperty("owner_id")]
        public ulong OwnerId { get; set; }
        [JsonProperty("permissions")]
        public ulong Permissions { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("afk_channel_id")]
        public ulong AfkChannelId { get; set; }
        [JsonProperty("afk_timeout")]
        public uint AfkTimeout { get; set; }
        [JsonProperty("embed_enabled")]
        public bool EmbedEnabled { get; set; }
        [JsonProperty("embed_channel_id")]
        public ulong EmbedChannelId { get; set; }
        [JsonProperty("verification_level")]
        public DiscordGuildVerificationLevel VerificationLevel { get; set; }
        [JsonProperty("default_message_notifications")]
        public DiscordGuildMessageNotificationLevel DefaultMessageNotification { get; set; }
        [JsonProperty("explicit_content_filter")]
        public DiscordGuildContentFilterLevel ExplicitContentFilter { get; set; }
        [JsonProperty("roles")]
        public DiscordRole[] Roles { get; set; }
        [JsonProperty("emojis")]
        public DiscordEmoji[] Emojis { get; set; }
        [JsonProperty("features")]
        public string[] Features { get; set; }
        [JsonProperty("mfa_level")]
        public DiscordGuildMfaLevel MfaLevel { get; set; }
        [JsonProperty("application_id")]
        public ulong ApplicationId { get; set; }
        [JsonProperty("widget_enabled")]
        public bool WidgetEnabled { get; set; }
        [JsonProperty("widget_channel_id")]
        public ulong WidgetChannelId { get; set; }
        [JsonProperty("system_channel_id")]
        public ulong SystemChannelId { get; set; }
        [JsonProperty("system_channel_flags")]
        public DiscordGuildSystemChannelFlags SystemChannelFlags { get; set; }
        [JsonProperty("rules_channel_id")]
        public ulong RulesChannelId { get; set; }
        [JsonProperty("joined_at")]
        public DateTime JoinedAt { get; set; }
        [JsonProperty("large")]
        public bool Large { get; set; }
        [JsonProperty("unavailable")]
        public bool IsUnavailable { get; set; }
        [JsonProperty("member_count")]
        public uint MemberCount { get; set; }
        [JsonProperty("voice_states")]
        public DiscordVoice[] VoicesStates { get; set; }
        [JsonProperty("members")]
        public DiscordGuildMember[] Members { get; set; }
        [JsonProperty("channels")]
        public DiscordChannel[] Channels { get; set; }
        [JsonProperty("presences")]
        public DiscordPresence[] Presences { get; set; }
        [JsonProperty("max_presences")]
        public uint MaxPresences { get; set; }
        [JsonProperty("max_members")]
        public uint MaxMembers { get; set; }
        [JsonProperty("vanity_url_code")]
        public string VanityUrlCode { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("banner")]
        public string Banner { get; set; }
        [JsonProperty("premium_tier")]
        public DiscordGuildPremiunTier PremiunTier { get; set; }
        [JsonProperty("premium_subscription_count")]
        public uint PremiumSubscriptionCount { get; set; }
        [JsonProperty("preferred_locale")]
        public string PreferredLocale { get; set; }
        [JsonProperty("public_updates_channel_id")]
        public ulong PublicUpdatesChannelId { get; set; }
        [JsonProperty("max_video_channel_users")]
        public uint MaxVideoChannelUsers { get; set; }
        [JsonProperty("approximate_member_count")]
        public uint ApproximateMemberCount { get; set; }
        [JsonProperty("approximate_presence_count")]
        public uint ApproximatePresenceCount { get; set; }
    }
}
