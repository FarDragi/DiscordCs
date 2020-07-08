using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DragiCordApi.Core.Models
{
    public class DiscordVoice
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }
        [JsonProperty("channel_id")]
        public ulong ChannelId { get; set; }
        [JsonProperty("user_id")]
        public ulong UserId { get; set; }
        [JsonProperty("member")]
        public DiscordGuildMember Member { get; set; }
        [JsonProperty("session_id")]
        public string SessionId { get; set; }
        [JsonProperty("deaf")]
        public bool IsDeaf { get; set; }
        [JsonProperty("mute")]
        public bool IsMute { get; set; }
        [JsonProperty("self_deaf")]
        public bool IsSeflDeaf { get; set; }
        [JsonProperty("self_mute")]
        public bool IsSelfMute { get; set; }
        [JsonProperty("self_stream")]
        public bool IsSelfStream { get; set; }
        [JsonProperty("suppress")]
        public bool IsSeppress { get; set; }
    }

}
