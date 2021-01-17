using FarDragi.DiscordCs.Json.Entities.IdentifyModels;

namespace FarDragi.DiscordCs.Gateway.Payloads
{
    public class IdentifyPayload : Payload<JsonIdentify>
    {
        public IdentifyPayload()
        {
            OpCode = PayloadOpCode.Identify;
        }
    }
}
