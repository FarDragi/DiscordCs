using FarDragi.DiscordCs.Entities.PayloadModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.EventsModels
{
    public class HeartbeatPayload : Payload<int?>
    {
        public HeartbeatPayload()
        {
            OpCode = PayloadOpCode.Heartbeat;
        }
    }
}
