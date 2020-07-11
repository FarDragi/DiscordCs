using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DragiCordApi.Core.Base.Models.Base
{
    public class DiscordGuild
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Splash { get; set; }
        public string DiscoverySplash { get; set; }
        public bool IsOwner { get; set; }
        public ulong OwnerId { get; set; }
        //public DiscordPermissions Permissions { get; set; }
        public string Region { get; set; }
        public ulong? AfkChannelId { get; set; }
        public uint AfkTimeout { get; set; }
        public bool EmbedEnabled { get; set; }
        public ulong? EmbedChannelId { get; set; }
        //public DiscordVerificationLevel VerificationLevel { get; set; }
        //public DiscordMessageNotificationLevel DefaultMessageNotification { get; set; }
        //public DiscordContentFilterLevel ExplicitContentFilter { get; set; }
        //public DiscordRole[] Roles { get; set; }
        //public DiscordEmoji[] Emojis { get; set; }
        public string[] Features { get; set; }
        //public DiscordMfaLevel MfaLevel { get; set; }
        public ulong? ApplicationId { get; set; }
        public bool WidgetEnabled { get; set; }
        public ulong? WidgetChannelId { get; set; }
        public ulong? SystemChannelId { get; set; }
        //public DiscordSystemChannel SystemChannelFlags { get; set; }
        public ulong? RulesChannelId { get; set; }
        public DateTime JoinedAt { get; set; }
        public bool Large { get; set; }
        public bool IsUnavailable { get; set; }
        public uint MemberCount { get; set; }
        //public DiscordVoice[] VoicesStates { get; set; }
        //public DiscordMember[] Members { get; set; }
        //public DiscordChannel[] Channels { get; set; }
        //public DiscordPresence[] Presences { get; set; }
        public uint? MaxPresences { get; set; }
        public uint MaxMembers { get; set; }
        public string VanityUrlCode { get; set; }
        public string Description { get; set; }
        public string Banner { get; set; }
        //public DiscordPremiumTier PremiunTier { get; set; }
        public uint PremiumSubscriptionCount { get; set; }
        public string PreferredLocale { get; set; }
        public ulong? PublicUpdatesChannelId { get; set; }
        public uint MaxVideoChannelUsers { get; set; }
        public uint ApproximateMemberCount { get; set; }
        public uint ApproximatePresenceCount { get; set; }
    }
}
