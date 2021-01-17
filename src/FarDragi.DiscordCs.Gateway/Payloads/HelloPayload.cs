using FarDragi.DiscordCs.Entities.HelloModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Payloads
{
    public class HelloPayload : Payload<JsonHello>
    {
        public HelloPayload()
        {
            OpCode = PayloadOpCode.Hello;
        }
    }
}
