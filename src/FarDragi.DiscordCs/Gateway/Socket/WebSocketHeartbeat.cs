using FarDragi.DiscordCs.Entities.HelloModels;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Gateway.Socket
{
    public class WebSocketHeartbeat
    {
        private readonly WebSocketClient webSocket;

        public bool Stop { get; set; }

        public WebSocketHeartbeat(WebSocketClient webSocket)
        {
            this.webSocket = webSocket;
        }

        public async void Heartbeat(Hello hello)
        {
            while (true)
            {
                await Task.Delay(hello.HeartbeatInterval);
                if (Stop)
                {
                    return;
                }
            }
        }
    }
}
