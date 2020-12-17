using FarDragi.DiscordCs.Core.Utils.Constants;
using FarDragi.DiscordCs.Core.Websocket.Extencions;
using FarDragi.DiscordCs.Core.Websocket.Interfaces;
using FarDragi.DiscordCs.Core.Websocket.Models.Base;
using FarDragi.DiscordCs.Core.Websocket.Models.Payloads;
using Newtonsoft.Json;
using System;
using System.Text;
using WebSocket4Net;

namespace FarDragi.DiscordCs.Core.Websocket
{
    public class WebsocketBase
    {
        private readonly IWebsocketData data;
        private readonly IWebsocketEvents events;
        private readonly Descompressor descompressor;
        private readonly WebSocket socket;

        public WebsocketBase(IWebsocket websocket)
        {
            data = websocket;
            events = websocket;
            descompressor = new Descompressor();
            socket = new WebSocket(WebsocketUrl.FinalUrl);
        }

        public void Open()
        {
            socket.Opened += Socket_Opened;
            socket.Closed += Socket_Closed;
            socket.DataReceived += Socket_DataReceived;
            socket.Open();
        }

        public void SendMessage<TData>(Payload<TData> payload)
        {
            string json = JsonConvert.SerializeObject(payload);
            Console.WriteLine(json);
            byte[] buffer = Encoding.UTF8.GetBytes(json);
            socket.Send(buffer, 0, buffer.Length);
        }

        private void Socket_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (descompressor.TryDecompress(e.Data, out string json))
            {
                events.OnDataReceived(json);
            }
        }

        private void Socket_Closed(object sender, EventArgs e)
        {
        }

        private void Socket_Opened(object sender, EventArgs e)
        {
            events.OnOpened();
        }
    }
}
