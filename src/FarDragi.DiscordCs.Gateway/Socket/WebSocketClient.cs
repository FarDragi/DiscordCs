using System;
using System.Collections.Generic;
using System.Text;
using WebSocket4Net;

namespace FarDragi.DiscordCs.Gateway.Socket
{
    public class WebSocketClient
    {
        public WebSocket socket;

        public WebSocketClient()
        {
            WebSocketConfig config = new WebSocketConfig
            {
                ApiVersion = "8",
                Encoding = "json"
            };
            socket = new WebSocket(config.Url);
        }

        public WebSocketClient(WebSocketConfig config)
        {
            socket = new WebSocket(config.Url);
        }
    }
}
