using FarDragi.DiscordCs.Core.Websocket.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Core.Websocket
{
    public class WebsocketBase
    {
        private readonly IWebsocketData data;
        private readonly IWebsocketEvents events;
        private readonly WebsocketConfig config;

        public WebsocketBase(DiscordWebsocket websocket, WebsocketConfig config)
        {
            data = websocket;
            events = websocket;
            this.config = config;
        }
    }
}
