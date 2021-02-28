using FarDragi.DiscordCs.Gateway;

namespace FarDragi.DiscordCs
{
    public class ClientEventArgs<TType>
    {
        public GatewayClient Gateway { get; set; }
        public TType Data { get; set; }
    }
}
