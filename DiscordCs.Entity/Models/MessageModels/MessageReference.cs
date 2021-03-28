using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.MessageModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#message-object-message-reference-structure
    /// </summary>
    public class MessageReference
    {
        [JsonPropertyName("message_id")]
        public ulong? MessageId { get; set; }

        [JsonPropertyName("channel_id")]
        public ulong? ChannelId { get; set; }

        [JsonPropertyName("guild_id")]
        public ulong? GuildId { get; set; }
    }
}
