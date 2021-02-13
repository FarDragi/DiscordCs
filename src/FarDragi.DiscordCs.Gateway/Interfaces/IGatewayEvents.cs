namespace FarDragi.DiscordCs.Gateway.Interfaces
{
    public interface IGatewayEvents
    {
        public void OnRaw(GatewayClient gateway, string data);
    }
}
