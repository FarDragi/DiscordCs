using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.PayloadModels
{
    public class PayloadData<TType>
    {
        [JsonPropertyName("d")]
        public TType Data { get; set; }
    }
}
