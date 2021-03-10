using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Gateway
{
    public interface IGatewayClient : IDisposable
    {
        public long Ping { get; }
        Task Open();
    }
}
