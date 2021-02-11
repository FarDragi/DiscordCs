namespace FarDragi.DiscordCs.Gateway.Interfaces
{
    public interface IGatewayEvents
    {
        public void OnRawAsync(GatewayClient gateway, string data);
    }
}
