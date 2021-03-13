using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-example-guild-news-channel
    /// </summary>
    public class NewsChannel : GuildChannel
    {
        [JsonPropertyName("topic")]
        public string Topic { get; set; }

        [JsonPropertyName("last_message_id")]
        public ulong? LastMessageId { get; set; }
    }
}
