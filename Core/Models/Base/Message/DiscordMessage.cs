using FarDragi.DiscordCs.Core.Models.Base.Guild;
using FarDragi.DiscordCs.Core.Models.Base.Member;
using FarDragi.DiscordCs.Core.Models.Base.User;
using FarDragi.DiscordCs.Core.Models.Collections;
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
        public DiscordMentionList UserMentions { get; set; }
        public DiscordRoleList RolesMentions { get; set; }
        public DiscordGuildChannels Channels { get; set; }
        public DiscordMessageAttachmentList Attachments { get; set; }

        // TODO fazer os embeds
    }
}
