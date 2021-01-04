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
    }
}
