using FarDragi.DiscordCs.Entity.Collections;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-channel-structure
    /// </summary>
    public class PrivateChannel : Channel
    {
        [JsonPropertyName("last_message_id")]
        public ulong? LastMessageId { get; set; }

        [JsonPropertyName("recipients")]
        public UserCollection Recipients { get; set; }
    }
}
