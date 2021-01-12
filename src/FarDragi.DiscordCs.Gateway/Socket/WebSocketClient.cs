using SuperSocket.ClientEngine;
using System;
using WebSocket4Net;

namespace FarDragi.DiscordCs.Gateway.Socket
{
    public class WebSocketClient
    {
        private WebSocket socket;
        private WebSocketDecompress decompress;
        private GatewayClient gatewayClient;

        public WebSocketClient(GatewayClient gatewayClient)
        {
            this.gatewayClient = gatewayClient;
            decompress = new WebSocketDecompress();
            WebSocketConfig config = new WebSocketConfig
            {
                ApiVersion = "8",
                Encoding = "json"
            };
            socket = new WebSocket(config.Url);
            socket.Opened += Socket_Opened;
            socket.DataReceived += Socket_DataReceived;
            socket.Error += Socket_Error;
        }

        private void Socket_Error(object sender, ErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Socket_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (decompress.TryDecompress(e.Data, out string json))
            {
                gatewayClient.OnEventReceived(json);
            }
        }

        private void Socket_Opened(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            socket.Open();
        }
    }
}
