using FarDragi.DiscordCs.Entities.AttachmentModels;
using FarDragi.DiscordCs.Entities.EmbedModels;
using FarDragi.DiscordCs.Entities.MemberModels;
using FarDragi.DiscordCs.Entities.RoleModels;
using FarDragi.DiscordCs.Entities.UserModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.MessageModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#message-object-message-structure
    /// </summary>
    public class Message
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("channel_id")]
        public ulong ChannelId { get; set; }

        [JsonProperty("guild_id")]
        public ulong? GuildId { get; set; }

        [JsonProperty("author")]
        public User User { get; set; }

        [JsonProperty("member")]
        public Member Member { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("edited_timestamp")]
        public DateTime? EditedTimestamp { get; set; }

        [JsonProperty("tts")]
        public bool IsTts { get; set; }

        [JsonProperty("mention_everyone")]
        public bool IsMentionEveryone { get; set; }

        [JsonProperty("mentions")]
        public UserMention[] UserMentions { get; set; }

        [JsonProperty("mention_roles")]
        public ulong[] MentionRoles { get; set; }

        [JsonProperty("mention_channels")]
        public ulong[] MentionChannels { get; set; }

        [JsonProperty("attachments")]
        public Attachment[] Attachments { get; set; }

        [JsonProperty("embeds")]
        public Embed[] Embeds { get; set; }

        [JsonProperty("reactions")]
        public MessageReaction[] Reactions { get; set; }

        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        [JsonProperty("pinned")]
        public bool IsPinned { get; set; }

        [JsonProperty("webhook_id")]
        public ulong? WebhookId { get; set; }

        [JsonProperty("type")]
        public MessageTypes Type { get; set; }

        [JsonProperty("activity")]
        public MessageActivity Activity { get; set; }

        [JsonProperty("application")]
        public MessageApplication Application { get; set; }

        [JsonProperty("message_reference")]
        public MessageReference MessageReference { get; set; }

        [JsonProperty("flags")]
        public MessageFlags Flags { get; set; }

        [JsonProperty("stickers")]
        public MessageSticker[] Stickers { get; set; }

        [JsonProperty("referenced_message")]
        public Message ReferencedMessage { get; set; }
    }
}
