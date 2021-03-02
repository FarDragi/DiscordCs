using FarDragi.DiscordCs.Entity.Models.MemberModels;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.VoiceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/voice#voice-state-object
    /// </summary>
    public class Voice
    {
        [JsonPropertyName("guild_id")]
        public ulong? GuildId { get; set; }

        [JsonPropertyName("channel_id")]
        public ulong? ChannelId { get; set; }

        [JsonPropertyName("user_id")]
        public ulong UserId { get; set; }

        [JsonPropertyName("member")]
        public Member Member { get; set; }

        [JsonPropertyName("session_id")]
        public string SessionId { get; set; }

        [JsonPropertyName("deaf")]
        public bool IsDeaf { get; set; }

        [JsonPropertyName("mute")]
        public bool IsMute { get; set; }

        [JsonPropertyName("self_deaf")]
        public bool IsSelfDeaf { get; set; }

        [JsonPropertyName("self_mute")]
        public bool IsSelfMute { get; set; }

        [JsonPropertyName("self_stream")]
        public bool IsSelfStream { get; set; }

        [JsonPropertyName("self_video")]
        public bool IsSelfVideo { get; set; }

        [JsonPropertyName("suppress")]
        public bool ISSuppress { get; set; }
    }
}
