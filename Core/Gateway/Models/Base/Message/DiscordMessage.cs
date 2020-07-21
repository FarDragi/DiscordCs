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
        [JsonProperty("id")]
        internal ulong Id { get; set; }

        [JsonProperty("channel_id")]
        internal ulong ChannelId { get; set; }

        [JsonProperty("guild_id")]
        internal ulong GuildId { get; set; }

        [JsonProperty("author")]
        internal DiscordUser Author { get; set; }

        [JsonProperty("member")]
        internal DiscordMember Member { get; set; }

        [JsonProperty("content")]
        internal string Content { get; set; }

        [JsonProperty("timestamp")]
        internal DateTime Timestamp { get; set; }

        [JsonProperty("edited_timestamp")]
        internal DateTime? EditedTimestamp { get; set; }

        [JsonProperty("tts")]
        internal bool IdTts { get; set; }

        [JsonProperty("mention_everyone")]
        internal bool IsMentionEveryone { get; set; }

        [JsonProperty("mentions")]
        internal DiscordMentionUser[] Mentions { get; set; }

        [JsonProperty("mention_roles")]
        internal DiscordRole[] MentionRoles { get; set; }

        [JsonProperty("mention_channels")]
        internal DiscordChannel[] MentionChannels { get; set; }

        [JsonProperty("attachments")]
        internal DiscordAttachment[] Attachments { get; set; }

        [JsonProperty("embeds")]
        internal DiscordEmbed[] Embeds { get; set; }

        [JsonProperty("reactions")]
        internal DiscordMessageReaction[] Reactions { get; set; }

        [JsonProperty("nonce")]
        internal string Nonce { get; set; }

        [JsonProperty("pinned")]
        internal bool IsPinned { get; set; }

        [JsonProperty("webhook_id")]
        internal ulong WebhookId { get; set; }

        [JsonProperty("type")]
        internal DiscordMessageType Type { get; set; }

        [JsonProperty("activity")]
        internal DiscordMessageActivity Activity { get; set; }

        [JsonProperty("application")]
        internal DiscordMessageApplication Application { get; set; }

        [JsonProperty("message_reference")]
        internal DiscordMessageReference Reference { get; set; }

        [JsonProperty("flags")]
        internal DiscordMessageFlags Flags { get; set; }
    }
}
