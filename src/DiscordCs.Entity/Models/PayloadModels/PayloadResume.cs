using FarDragi.DiscordCs.Entity.Models.ResumeModels;

namespace FarDragi.DiscordCs.Entity.Models.PayloadModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#resuming
    /// </summary>
    public class PayloadResume : Payload<Resume>
    {
        public PayloadResume()
        {
            OpCode = PayloadOpCode.Resume;
        }
    }
}
