namespace FarDragi.DiscordCs.Entity.Models.PayloadModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#heartbeating
    /// </summary>
    public class PayloadHeartbeat : Payload<int>
    {
        public PayloadHeartbeat()
        {
            OpCode = PayloadOpCode.Heartbeat;
        }
    }
}
