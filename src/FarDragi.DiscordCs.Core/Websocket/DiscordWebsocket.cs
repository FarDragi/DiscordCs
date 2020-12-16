using FarDragi.DiscordCs.Core.Client;
using FarDragi.DiscordCs.Core.Websocket.Interfaces;

namespace FarDragi.DiscordCs.Core.Websocket
{
    public class DiscordWebsocket : IWebsocketData, IWebsocketEvents
    {
        private readonly ClientBase client;
        private readonly WebsocketBase websocket;

        public DiscordWebsocket(ClientBase client, WebsocketConfig config)
        {
            this.client = client;
            websocket = new WebsocketBase(this, config);
        }
    }
}
