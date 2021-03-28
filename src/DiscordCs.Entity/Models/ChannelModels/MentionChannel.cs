using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-mention-object-channel-mention-structure
    /// </summary>
    public class MentionChannel
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("guild_id")]
        public ulong GuildId { get; set; }

        [JsonPropertyName("type")]
        public ChannelTypes Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
