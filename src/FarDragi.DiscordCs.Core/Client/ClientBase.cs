using FarDragi.DiscordCs.Core.Client.Interfaces;
using FarDragi.DiscordCs.Core.Websocket;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Core.Client
{
    public class ClientBase
    {
        private readonly DiscordWebsocket websocket;
        private readonly IClientData data;
        private readonly IClientEvents events;

        public ClientBase(IClient client, WebsocketConfig config)
        {
            data = client;
            events = client;
            websocket = new DiscordWebsocket(this, config);
        }

        public void OnDataReceived()
        {
            
        }

        public void Connect()
        {
            websocket.Open();
        }
    }
}
