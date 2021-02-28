using FarDragi.DiscordCs.Entities.IdentifyModels;

namespace FarDragi.DiscordCs.Gateway.Payloads
{
    public class IdentifyPayload : Payload<Identify>
    {
        public IdentifyPayload()
        {
            OpCode = PayloadOpCode.Identify;
        }
    }
}
