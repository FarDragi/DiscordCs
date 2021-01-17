using FarDragi.DiscordCs.Entities.HelloModels;
using FarDragi.DiscordCs.Entities.PayloadModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.EventsModels
{
    public class HelloPayload : Payload<Hello>
    {
        public HelloPayload()
        {
            OpCode = PayloadOpCode.Hello;
        }
    }
}
