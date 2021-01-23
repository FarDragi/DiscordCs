using FarDragi.DiscordCs.Json.Entities.MemberModels;
using FarDragi.DiscordCs.Json.Entities.UserModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Json.Entities.MessageModels
{
    public class JsonMessage
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("channel_id")]
        public ulong ChannelId { get; set; }

        [JsonProperty("guild_id")]
        public ulong? GuildId { get; set; }

        [JsonProperty("author")]
        public JsonUser User { get; set; }

        [JsonProperty("member")]
        public JsonMember Member { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("edited_timestamp")]
        public DateTime? EditedTimestamp { get; set; }

        [JsonProperty("tts")]
        public bool Tts { get; set; }

        [JsonProperty("mention_everyone")]
        public bool MentionEveryone { get; set; }

        [JsonProperty("mentions")]
        public JsonUser[] Mentions { get; set; }
    }
}
