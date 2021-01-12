using FarDragi.DiscordCs.Gateway.Interface;
using FarDragi.DiscordCs.Gateway.Socket;

namespace FarDragi.DiscordCs.Gateway
{
    public class GatewayClient
    {
        private IGatewayEvents events;
        private WebSocketClient webSocket;

        public GatewayClient(IGatewayEvents events)
        {
            this.events = events;
            webSocket = new WebSocketClient(this);
        }

        public void Open()
        {
            webSocket.Open();
        }

        public void OnEventReceived(string json)
        {

        }
    }
}
