using FarDragi.DiscordCs.Entity.Models.MemberModels;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.MessageModels
{
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

        // TODO: adicionar o resto
    }
}
