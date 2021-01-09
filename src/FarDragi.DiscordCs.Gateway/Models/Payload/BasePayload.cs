using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Models.Payload
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#payloads-gateway-payload-structure
    /// </summary>
    /// <typeparam name="T">DataType</typeparam>
    public class BasePayload<T>
    {
        [JsonProperty("op")]
        public PayloadOpCode OpCode { get; set; }
        [JsonProperty("d")]
        public T Data { get; set; }
        [JsonProperty("s")]
        public int SequenceNumber { get; set; }
        [JsonProperty("t")]
        public string Event { get; set; }
    }
}
