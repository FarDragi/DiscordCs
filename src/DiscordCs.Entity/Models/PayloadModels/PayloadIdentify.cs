using FarDragi.DiscordCs.Entity.Models.IdentifyModels;

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
