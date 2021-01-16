using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.PayloadModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#payloads-gateway-payload-structure
    /// </summary>
    /// <typeparam name="TData">DataType</typeparam>
    public class Payload<TData>
    {
        [JsonProperty("op")]
        public PayloadOpCode OpCode { get; set; }

        [JsonProperty("d")]
        public TData Data { get; set; }

        [JsonProperty("s")]
        public int? SequenceNumber { get; set; }

        [JsonProperty("t")]
        public string Event { get; set; }
    }
}
