using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Models.Payload
{
    public class BasePayload<T>
    {
        public int OpCode { get; set; }
        public T Data { get; set; }
        public int SequenceNumber { get; set; }
        public string Event { get; set; }
    }
}
