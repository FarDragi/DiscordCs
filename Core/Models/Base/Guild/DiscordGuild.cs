using FarDragi.DiscordCs.Core.Models.Collections;
using FarDragi.DiscordCs.Core.Models.Enums.Guild;
using System;

namespace FarDragi.DiscordCs.Core.Models.Base.Guild
{
    public class DiscordGuild
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public ulong OwnerId { get; set; }
        public string Region { get; set; }
        public string Splash { get; set; }
        public string DiscoverySplash { get; set; }
        public bool IsUnavailable { get; set; }
        public DiscordGuildConfig Config { get; set; }
        public DiscordRoleList Roles { get; set; }
        public DiscordEmojiList Emojis { get; set; }
        public DiscordGuildFeatures Features { get; set; }
        public DiscordGuildMfaLevel MfaLevel { get; set; }
        public ulong? ApplicationId { get; set; }
        public ulong? RulesChannelId { get; set; }
        public DateTime JoinedAt { get; set; }
        public bool IsLarge { get; set; }
        public uint MemberCount { get; set; }
        public DiscordVoiceList VoicesStates { get; set; }
        public DiscordMemberList Members { get; set; }
        public DiscordGuildChannels Channels { get; set; }
        public DiscordPresenceList Presences { get; set; }
        public uint? MaxPresences { get; set; }
        public uint MaxMembers { get; set; }
        public string VanityUrlCode { get; set; }
        public string Banner { get; set; }
        public DiscordGuildPremiumTier PremiumTier { get; set; }
        public uint PremiumSubscriptionCount { get; set; }
        public string PreferredLocale { get; set; }
        public ulong? PublicUpdatesChannelId { get; set; }
        public uint MaxVideoChannelUsers { get; set; }
        public uint ApproximateMemberCount { get; set; }
        public uint ApproximatePresenceCount { get; set; }
    }
}
