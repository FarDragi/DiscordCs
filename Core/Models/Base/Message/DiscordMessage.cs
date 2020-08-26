using FarDragi.DiscordCs.Core.Models.Base.Member;
using FarDragi.DiscordCs.Core.Models.Base.User;
using System;

namespace FarDragi.DiscordCs.Core.Models.Base.Message
{
    public class DiscordMessage
    {
        public ulong Id { get; set; }
        public ulong ChannelId { get; set; }
        public ulong GuildId { get; set; }
        public DiscordUser Author { get; set; }
        public DiscordMember Member { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public DateTime? EditedTimestamp { get; set; }
        public bool IsTts { get; set; }
        public bool IsMentionEveryone { get; set; }
    }
}
