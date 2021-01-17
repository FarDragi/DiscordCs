namespace FarDragi.DiscordCs.Gateway.Payloads
{
    public class HeartbeatPayload : Payload<int?>
    {
        public HeartbeatPayload()
        {
            OpCode = PayloadOpCode.Heartbeat;
        }
    }
}
