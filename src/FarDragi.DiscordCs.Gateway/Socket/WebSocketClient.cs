using FarDragi.DiscordCs.Gateway.Models.Identify;
using FarDragi.DiscordCs.Gateway.Models.Payload;
using Newtonsoft.Json;
using SuperSocket.ClientEngine;
using System;
using System.Text;
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
            Console.WriteLine(e.Exception);
        }

        private void Socket_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (decompress.TryDecompress(e.Data, out string json))
            {
                BasePayload<object> payload = JsonConvert.DeserializeObject<BasePayload<object>>(json);

                Console.WriteLine(json);

                switch (payload.OpCode)
                {
                    case PayloadOpCode.Dispatch:
                        gatewayClient.OnEventReceived(payload.Event, payload.Data);
                        break;
                    case PayloadOpCode.Hello:
                        break;
                    case PayloadOpCode.Heartbeat:
                        break;
                    case PayloadOpCode.Reconnect:
                        break;
                    case PayloadOpCode.InvalidSession:
                        break;
                    case PayloadOpCode.HeartbeatACK:
                        break;
                    default:
                        break;
                }
            }
        }

        private void Socket_Opened(object sender, EventArgs e)
        {
            Send<DiscordIdentify>(new BasePayload<DiscordIdentify>
            {
                OpCode = PayloadOpCode.Identify,
                Data = new DiscordIdentify
                {
                    token = "",
                    intents = 32509,
                    properties = new IdentifyProperties
                    {
                        os = Environment.OSVersion.Platform.ToString(),
                        browser = "DiscordCs",
                        device = "DiscordCs"
                    },
                    compress = true,
                    largeThreshold = 50,
                    shard = new int[] { 0, 1 },
                    guildSubscriptions = false,
                    presence = new Models.Presence.PresenceStatusUpdate
                    {
                        Afk = false,
                        Since = null,
                        Status = "online"
                    }
                }
            });
        }

        public void Open()
        {
            socket.Open();
        }

        public void Send<TDataType>(BasePayload<TDataType> obj)
        {
            string json = JsonConvert.SerializeObject(obj);

            Console.WriteLine(json);

            byte[] payload = Encoding.UTF8.GetBytes(json);
            socket.Send(payload, 0, payload.Length);
        }
    }
}
