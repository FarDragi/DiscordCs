using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ResumeModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#resuming
    /// </summary>
    public class Resume
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("session_id")]
        public string SessionId { get; set; }

        [JsonPropertyName("seq")]
        public int? SequenceNumber { get; set; }
    }
}
