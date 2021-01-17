using FarDragi.DiscordCs.Entities.MemberModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.VoiceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/voice#voice-state-object
    /// </summary>
    public class Voice
    {
        [JsonProperty("guild_id")]
        public ulong? GuildId { get; set; }

        [JsonProperty("channel_id")]
        public ulong? ChannelId { get; set; }

        [JsonProperty("user_id")]
        public ulong UserId { get; set; }

        [JsonProperty("member")]
        public Member Member { get; set; }

        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("deaf")]
        public bool Deaf { get; set; }

        [JsonProperty("mute")]
        public bool Mute { get; set; }

        [JsonProperty("self_deaf")]
        public bool SelfDeaf { get; set; }

        [JsonProperty("self_mute")]
        public bool SelfMute { get; set; }

        [JsonProperty("self_stream")]
        public bool SelfStream { get; set; }

        [JsonProperty("self_video")]
        public bool SelfVideo { get; set; }

        [JsonProperty("suppress")]
        public bool Suppress { get; set; }
    }
}
