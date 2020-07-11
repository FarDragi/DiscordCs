using FarDragi.DragiCordApi.Core.Gateway.Extensions;
using FarDragi.DragiCordApi.Core.Gateway.Models.Payloads;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text;
using System.Threading.Tasks;
using WebSocket4Net;

namespace FarDragi.DragiCordApi.Core.Gateway.Client
{
    internal sealed class GatewayWebSocket : IDisposable
    {
        internal delegate Task MessageReceived(string e);
        internal delegate Task DataReceived(string e);
        internal delegate Task Opened(EventArgs e);

        internal event MessageReceived SocketMessageReceived;
        internal event DataReceived SocketDataReceived;
        internal event Opened SocketOpened;

        private readonly WebSocket _discordSocket = null;
        private readonly DecompressedExtension _decompressor;
        internal ulong SessionCode = 0;

        public GatewayWebSocket(string socketUrl)
        {
            _decompressor = new DecompressedExtension();
            _discordSocket = new WebSocket(socketUrl);
            _discordSocket.MessageReceived += DiscordSocket_MessageReceived;
            _discordSocket.DataReceived += DiscordSocket_DataReceived;
            _discordSocket.Opened += DiscordSocket_Opened;
        }

        internal async Task Connect()
        {
            await _discordSocket.OpenAsync();
            await Task.Delay(-1);
        }

        internal void SendMessage<TData>(PayloadSend<TData> payload)
        {
            byte[] json = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(payload));
            _discordSocket.Send(json, 0, json.Length);
        }

        private void DiscordSocket_Opened(object sender, EventArgs e)
        {
            SocketOpened?.Invoke(e);
        }

        private void DiscordSocket_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (_decompressor.TryDecompress(e.Data, out string json))
            {
                SocketDataReceived?.Invoke(json);
            }
        }

        private void DiscordSocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            SocketMessageReceived?.Invoke(e.Message);
        }

        public void Dispose()
        {
            _discordSocket.Dispose();
        }
    }
}
