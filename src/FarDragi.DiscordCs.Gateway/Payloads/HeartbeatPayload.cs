using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Payloads
{
    public class HeartbeatPayload : Payload<int?>
    {
        public HeartbeatPayload()
        {
            OpCode = PayloadOpCode.Heartbeat;
        }
    }
}
