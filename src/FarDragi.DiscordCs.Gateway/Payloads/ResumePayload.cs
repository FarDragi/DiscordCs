using FarDragi.DiscordCs.Json.Entities.ResumeModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Payloads
{
    public class ResumePayload : Payload<JsonResume>
    {
        public ResumePayload()
        {
            OpCode = PayloadOpCode.Resume;
        }
    }
}
