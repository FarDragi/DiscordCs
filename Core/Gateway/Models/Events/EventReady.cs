using FarDragi.DragiCordApi.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DragiCordApi.Core.Gateway.Models.Events
{
    internal sealed class EventReady
    {
        [JsonProperty("v")]
        public uint Version { get; set; }
        [JsonProperty("user")]
        public DiscordUser User { get; set; }
        //[JsonProperty("private_channels")]
        //public int MyProperty { get; set; }
        [JsonProperty("guilds")]
        public DiscordGuild[] Guilds { get; set; }
        [JsonProperty("session_id")]
        public string SessionId { get; set; }
        [JsonProperty("shard")]
        public uint[] Shard { get; set; }
    }
}
