using FarDragi.DiscordCs.Core.Role;
using FarDragi.DiscordCs.Core.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Emoji
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/emoji#emoji-object-emoji-structure
    /// </summary>
    public interface IDiscordEmoji
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public IDiscordRole[] Roles { get; set; }
        public IDiscordUser User { get; set; }
        public bool RequireColons { get; set; }
        public bool Managed { get; set; }
        public bool Animated { get; set; }
        public bool Available { get; set; }
    }
}
