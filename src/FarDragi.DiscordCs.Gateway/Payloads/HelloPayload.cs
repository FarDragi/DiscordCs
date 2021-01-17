using FarDragi.DiscordCs.Json.Entities.HelloModels;

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
