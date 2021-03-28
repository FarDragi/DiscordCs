using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-example-guild-voice-channel
    /// </summary>
    public class VoiceChannel : GuildChannel
    {
        [JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }
    }
}
