using FarDragi.DiscordCs.Gateway;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Args
{
    public class ClientArgs<TEntity>
    {
        public IGatewayClient GatewayClient { get; set; }
        public TEntity Data { get; set; }
    }
}
