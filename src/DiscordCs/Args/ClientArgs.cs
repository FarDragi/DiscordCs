using FarDragi.DiscordCs.Gateway;

namespace FarDragi.DiscordCs.Args
{
    public class ClientArgs<TEntity>
    {
        public IGatewayClient GatewayClient { get; set; }
        public TEntity Data { get; set; }
    }
}
