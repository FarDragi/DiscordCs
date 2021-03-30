using System;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Gateway
{
    public interface IGatewayClient : IDisposable
    {
        public long Ping { get; }
        public string SessionId { get; set; }
        Task Open();
    }
}
