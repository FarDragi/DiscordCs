using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Models.Payload
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#payloads-gateway-payload-structure
    /// </summary>
    /// <typeparam name="TDataType">DataType</typeparam>
    public class BasePayload<TDataType>
    {
        [JsonProperty("op")]
        public PayloadOpCode OpCode { get; set; }

        [JsonProperty("d")]
        public TDataType Data { get; set; }

        [JsonProperty("s")]
        public int? SequenceNumber { get; set; }

        [JsonProperty("t")]
        public string Event { get; set; }
    }
}
