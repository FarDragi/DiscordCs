using FarDragi.DiscordCs.Core.Gateway.Models.Base.Member;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Voice
{
    internal class DiscordVoice
    {
        // Discord Voice
        [JsonProperty("guild_id")]
        internal ulong GuildId { get; set; }

        // Discord Voice
        [JsonProperty("channel_id")]
        internal ulong? ChannelId { get; set; }

        // Discord Voice
        [JsonProperty("user_id")]
        internal ulong UserId { get; set; }

        // Discord Voice
        [JsonProperty("member")]
        internal DiscordMember Member { get; set; }

        // Discord Voice
        [JsonProperty("session_id")]
        internal string SessionId { get; set; }

        // Discord Voice
        [JsonProperty("deaf")]
        internal bool IsDeaf { get; set; }

        // Discord Voice
        [JsonProperty("mute")]
        internal bool IsMute { get; set; }

        // Discord Voice
        [JsonProperty("self_deaf")]
        internal bool IsSelfDeaf { get; set; }

        // Discord Voice
        [JsonProperty("self_mute")]
        internal bool IsSelfMute { get; set; }

        // Discord Voice
        [JsonProperty("self_stream")]
        internal bool IsSelfStream { get; set; }

        // Discord Voice
        [JsonProperty("suppress")]
        internal bool IsSuppress { get; set; }
    }

}
