using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.MessageModels
{
    public class MessageDelete
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("channel_id")]
        public ulong ChannelId { get; set; }

        [JsonPropertyName("guild_id")]
        public ulong? GuildId { get; set; }
    }
}
