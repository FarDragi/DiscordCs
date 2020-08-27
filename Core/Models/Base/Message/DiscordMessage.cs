using FarDragi.DiscordCs.Core.Models.Base.Guild;
using FarDragi.DiscordCs.Core.Models.Base.Member;
using FarDragi.DiscordCs.Core.Models.Base.User;
using FarDragi.DiscordCs.Core.Models.Collections;
using FarDragi.DiscordCs.Core.Models.Enums.Message;
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
        public DiscordUserMentionList UserMentions { get; set; }
        public DiscordRoleList RolesMentions { get; set; }
        public DiscordGuildChannels ChannelsMentions { get; set; }
        public DiscordMessageAttachmentList Attachments { get; set; }
        public DiscordEmbedList Embeds { get; set; }
        public DiscordMessageReactionList Reactions { get; set; }
        public string Nonce { get; set; }
        public bool IsPinned { get; set; }
        public ulong WebhookId { get; set; }
        public DiscordMessageType MessageType { get; set; }
        public DiscordMessageActivity Activity { get; set; }
        public DiscordMessageApplication Application { get; set; }
        public DiscordMessageReference Reference { get; set; }
        public DiscordMessageFlags MessageFlags { get; set; }
    }
}
