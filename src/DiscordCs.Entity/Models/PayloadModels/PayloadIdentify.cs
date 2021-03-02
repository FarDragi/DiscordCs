using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entity.Models.PayloadModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#identifying
    /// </summary>
    public class PayloadIdentify : Payload<Identify>
    {
        public PayloadIdentify()
        {
            OpCode = PayloadOpCode.Identify;
        }
    }
}
