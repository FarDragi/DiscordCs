using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.HelloModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#hello-hello-structure
    /// </summary>
    public class Hello
    {
        [JsonProperty("heartbeat_interval")]
        public int HeartbeatInterval { get; set; }
    }
}
