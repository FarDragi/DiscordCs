namespace FarDragi.DiscordCs.Gateway
{
    public interface IGatewayConfig
    {
        public int Version { get; set; }
        public string Encoding { get; set; }
        public string BaseUrl { get; set; }
    }
}
