using FarDragi.DiscordCs.Core.User;
using System;

namespace FarDragi.DiscordCs.Core.Guild
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#guild-member-object-guild-member-structure
    /// </summary>
    public interface IGuildMember
    {
        public IDiscordUser User { get; set; }
        public string Nick { get; set; }
        public ulong[] Roles { get; set; }
        public DateTime JoinedAt { get; set; }
        public DateTime PremiumSince { get; set; }
        public bool Deaf { get; set; }
        public bool Mute { get; set; }
        public bool Pending { get; set; }
    }
}
