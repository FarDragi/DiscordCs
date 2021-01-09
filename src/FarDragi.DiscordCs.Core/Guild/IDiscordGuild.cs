using FarDragi.DiscordCs.Core.Emoji;
using FarDragi.DiscordCs.Core.Role;
using FarDragi.DiscordCs.Core.Voice;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Guild
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#guild-object-guild-structure
    /// </summary>
    public interface IDiscordGuild
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string IconHash { get; set; }
        public string Splash { get; set; }
        public string DiscoverySplash { get; set; }
        public bool Owner { get; set; }
        public ulong OwnerId { get; set; }
        public string Permissions { get; set; }
        public string Region { get; set; }
        public ulong AfkChannelId { get; set; }
        public int AfkTimeout { get; set; }
        public bool WidgetEnabled { get; set; }
        public ulong WidgetChannelId { get; set; }
        public int VerificationLevel { get; set; }
        public int DefaultMessageNotifications { get; set; }
        public int ExplicitContentFilter { get; set; }
        public IDiscordRole[] Roles { get; set; }
        public IDiscordEmoji[] Emojis { get; set; }
        public string[] Features { get; set; }
        public int MfaLevel { get; set; }
        public ulong ApplicationId { get; set; }
        public ulong SystemChannelId { get; set; }
        public int SystemChannelFlags { get; set; }
        public ulong RulesChannelId { get; set; }
        public DateTime JoinedAt { get; set; }
        public bool Large { get; set; }
        public bool Unavailable { get; set; }
        public int MemberCount { get; set; }
        public IDiscordVoice[] Voices { get; set; }
        public IGuildMember[] Members { get; set; }
    }
}
