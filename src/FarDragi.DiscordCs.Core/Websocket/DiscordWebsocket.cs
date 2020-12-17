using FarDragi.DiscordCs.Core.Client;
using FarDragi.DiscordCs.Core.Websocket.Interfaces;
using FarDragi.DiscordCs.Core.Websocket.Models.Payloads;

namespace FarDragi.DiscordCs.Core.Websocket
{
    public class DiscordWebsocket : IWebsocket
    {
        private readonly ClientBase client;
        private readonly WebsocketConfig config;
        private readonly WebsocketBase websocket;

        public DiscordWebsocket(ClientBase client, WebsocketConfig config)
        {
            this.client = client;
            this.config = config;
            websocket = new WebsocketBase(this);
        }

        public void Open()
        {
            websocket.Open();
        }

        public void OnDataReceived(string json)
        {
            System.Console.WriteLine(json);
        }

        public void OnOpened()
        {
            websocket.SendMessage(new GatewayIdentify(config.Identify));
        }
    }
}
