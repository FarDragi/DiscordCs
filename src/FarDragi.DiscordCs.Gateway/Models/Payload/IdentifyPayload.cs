using FarDragi.DiscordCs.Core.Json.Models.Identify;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Models.Payload
{
    public class IdentifyPayload : BasePayload<DiscordIdentify>
    {
        public IdentifyPayload()
        {
            OpCode = PayloadOpCode.Identify;
        }
    }
}
