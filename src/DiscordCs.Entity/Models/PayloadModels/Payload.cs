using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.PayloadModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#payloads-gateway-payload-structure
    /// </summary>
    /// <typeparam name="TType">DataType</typeparam>
    public class Payload<TType>
    {
        [JsonPropertyName("op")]
        public PayloadOpCode OpCode { get; set; }

        [JsonPropertyName("d")]
        public TType Data { get; set; }

        [JsonPropertyName("s")]
        public int? SequenceNumber { get; set; }

        [JsonPropertyName("t")]
        public string Event { get; set; }
    }
}
