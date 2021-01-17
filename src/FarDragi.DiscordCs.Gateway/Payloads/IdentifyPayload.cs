using FarDragi.DiscordCs.Json.Entities.IdentifyModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Payloads
{
    public class IdentifyPayload : Payload<JsonIdentify>
    {
        public IdentifyPayload()
        {
            OpCode = PayloadOpCode.Identify;
        }
    }
}
