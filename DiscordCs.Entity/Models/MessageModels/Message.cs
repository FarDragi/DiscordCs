using FarDragi.DiscordCs.Entity.Models.AttachmentModels;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using FarDragi.DiscordCs.Entity.Models.EmbedModels;
using FarDragi.DiscordCs.Entity.Models.MemberModels;
using FarDragi.DiscordCs.Entity.Models.ReactionModels;
using FarDragi.DiscordCs.Entity.Models.StickerModels;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.MessageModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#message-object-message-structure
    /// </summary>
    [DebuggerDisplay("({Id, nq}) {Content}")]
    public class Message
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("channel_id")]
        public ulong ChannelId { get; set; }

        [JsonPropertyName("guild_id")]
        public ulong? GuildId { get; set; }

        [JsonPropertyName("author")]
        public User Author { get; set; }

        [JsonPropertyName("member")]
        public Member Member { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("edited_timestamp")]
        public DateTime? EditedTimestamp { get; set; }

        [JsonPropertyName("tts")]
        public bool Tts { get; set; }

        [JsonPropertyName("mention_everyone")]
        public bool MentionEveryone { get; set; }

        [JsonPropertyName("mentions")]
        public User[] Mentions { get; set; }

        [JsonPropertyName("mention_roles")]
        public string[] MentionRoles { get; set; }

        [JsonPropertyName("mention_channels")]
        public MentionChannel MentionChannels { get; set; }

        [JsonPropertyName("attachments")]
        public Attachment[] Attachments { get; set; }

        [JsonPropertyName("embeds")]
        public Embed[] Embeds { get; set; }

        [JsonPropertyName("reactions")]
        public Reaction[] Reactions { get; set; }

        [JsonPropertyName("nonce")]
        public string Nonce { get; set; }

        [JsonPropertyName("pinned")]
        public bool IsPinned { get; set; }

        [JsonPropertyName("webhook_id")]
        public ulong? WebhookId { get; set; }

        [JsonPropertyName("type")]
        public MessageTypes Type { get; set; }

        [JsonPropertyName("activity")]
        public MessageActivity Activity { get; set; }

        [JsonPropertyName("application")]
        public MessageApplication Application { get; set; }

        [JsonPropertyName("message_reference")]
        public MessageReference MessageReference { get; set; }

        [JsonPropertyName("flags")]
        public MessageFlags Flags { get; set; }

        [JsonPropertyName("stickers")]
        public Sticker[] Stickers { get; set; }

        [JsonPropertyName("referenced_message")]
        public Message ReferencedMessage { get; set; }

        [JsonPropertyName("interaction")]
        public MessageInteraction Interaction { get; set; }
    }
}
