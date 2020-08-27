using FarDragi.DiscordCs.Core.Gateway.Models.Base.Channel;
using FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed;
using FarDragi.DiscordCs.Core.Gateway.Models.Base.Member;
using FarDragi.DiscordCs.Core.Gateway.Models.Base.Role;
using FarDragi.DiscordCs.Core.Gateway.Models.Base.User;
using FarDragi.DiscordCs.Core.Gateway.Models.Enums.Message;
using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Message
{
    internal class DiscordMessage
    {
        // Discord Message
        [JsonProperty("id")]
        internal ulong Id { get; set; }

        // Discord Message
        [JsonProperty("channel_id")]
        internal ulong ChannelId { get; set; }

        // Discord Message
        [JsonProperty("guild_id")]
        internal ulong GuildId { get; set; }

        // Discord Message
        [JsonProperty("author")]
        internal DiscordUser Author { get; set; }

        // Discord Message
        [JsonProperty("member")]
        internal DiscordMember Member { get; set; }

        // Discord Message
        [JsonProperty("content")]
        internal string Content { get; set; }

        // Discord Message
        [JsonProperty("timestamp")]
        internal DateTime Timestamp { get; set; }

        // Discord Message
        [JsonProperty("edited_timestamp")]
        internal DateTime? EditedTimestamp { get; set; }

        // Discord Message
        [JsonProperty("tts")]
        internal bool IsTts { get; set; }

        // Discord Message
        [JsonProperty("mention_everyone")]
        internal bool IsMentionEveryone { get; set; }

        // Discord Message
        [JsonProperty("mentions")]
        internal DiscordUserMention[] UserMentions { get; set; }

        // Discord Message
        [JsonProperty("mention_roles")]
        internal DiscordRole[] MentionRoles { get; set; }

        // Discord Message
        [JsonProperty("mention_channels")]
        internal DiscordChannel[] MentionChannels { get; set; }

        // Discord Message
        [JsonProperty("attachments")]
        internal DiscordMessageAttachment[] Attachments { get; set; }

        // Discord Message
        [JsonProperty("embeds")]
        internal DiscordEmbed[] Embeds { get; set; }

        // Discord Message
        [JsonProperty("reactions")]
        internal DiscordMessageReaction[] Reactions { get; set; }

        // Discord Message
        [JsonProperty("nonce")]
        internal string Nonce { get; set; }

        // Discord Message
        [JsonProperty("pinned")]
        internal bool IsPinned { get; set; }

        // Discord Message
        [JsonProperty("webhook_id")]
        internal ulong WebhookId { get; set; }

        // Discord Message
        [JsonProperty("type")]
        internal DiscordMessageType MessageType { get; set; }

        // Discord Message
        [JsonProperty("activity")]
        internal DiscordMessageActivity Activity { get; set; }

        // Discord Message
        [JsonProperty("application")]
        internal DiscordMessageApplication Application { get; set; }

        // Discord Message
        [JsonProperty("message_reference")]
        internal DiscordMessageReference Reference { get; set; }

        // Discord Message
        [JsonProperty("flags")]
        internal DiscordMessageFlags MessageFlags { get; set; }
    }
}
