using FarDragi.DiscordCs.Core.Utils.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocket4Net;

namespace FarDragi.DiscordCs.Core.Websocket
{
    public class BaseWebsocket
    {
        private readonly WebSocket socket;

        public ConfigWebsocket Config { get; }

        public BaseWebsocket(ConfigWebsocket config)
        {
            Config = config;
            socket = new WebSocket(WebsocketUrl.FinalUrl);
        }

        public Task<bool> OpenAsync()
        {
            socket.Opened += Socket_Opened;
            socket.Closed += Socket_Closed;
            socket.MessageReceived += Socket_MessageReceived;
            return socket.OpenAsync();
        }

        private void Socket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Socket_Closed(object sender, EventArgs e)
        {
            socket.Opened -= Socket_Opened;
            socket.Closed -= Socket_Closed;
            socket.MessageReceived -= Socket_MessageReceived;
        }

        private void Socket_Opened(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
