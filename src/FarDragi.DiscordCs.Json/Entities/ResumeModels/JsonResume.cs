using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Json.Entities.ResumeModels
{
    public class JsonResume
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("seq")]
        public int? SequenceNumber { get; set; }
    }
}
