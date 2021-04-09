using FarDragi.DiscordCs.Entity.Models.PermissionModels;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-example-guild-voice-channel
    /// </summary>
    public class VoiceChannel : Channel
    {
        [JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }
    }
}
