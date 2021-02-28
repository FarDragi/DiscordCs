using FarDragi.DiscordCs.Json.Entities.ResumeModels;

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
