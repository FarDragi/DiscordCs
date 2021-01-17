﻿using FarDragi.DiscordCs.Entities.IdentifyModels;
using FarDragi.DiscordCs.Entities.PayloadModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.EventsModels
{
    public class PayloadIdentify : Payload<Identify>
    {
        public PayloadIdentify()
        {
            OpCode = PayloadOpCode.Identify;
        }
    }
}
