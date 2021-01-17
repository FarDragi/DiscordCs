using FarDragi.DiscordCs.Entities.EventsModels;
using FarDragi.DiscordCs.Entities.HelloModels;
using FarDragi.DiscordCs.Entities.IdentifyModels;
using FarDragi.DiscordCs.Entities.PayloadModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SuperSocket.ClientEngine;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSocket4Net;

namespace FarDragi.DiscordCs.Gateway.Socket
{
    public class WebSocketClient
    {
        private readonly WebSocket socket;
        private readonly WebSocketDecompress decompress;
        private readonly GatewayClient gatewayClient;
        private readonly Identify identify;

        private int? sequenceNumber;

        public WebSocketClient(GatewayClient gatewayClient, Identify identify)
        {
            this.gatewayClient = gatewayClient;
            this.identify = identify;
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
                Payload<JObject> payload = JsonConvert.DeserializeObject<Payload<JObject>>(json);
                sequenceNumber = payload.SequenceNumber;

                Console.WriteLine(json);

                switch (payload.OpCode)
                {
                    case PayloadOpCode.Dispatch:
                        gatewayClient.OnEventReceived(payload.Event, payload.Data);
                        break;
                    case PayloadOpCode.Hello:
                        Heartbeat(payload.Data.ToObject<Hello>());
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
            Send(new IdentifyPayload
            {
                Data = identify
            });
        }

        private async void Heartbeat(Hello hello)
        {
            while (true)
            {
                await Task.Delay(hello.HeartbeatInterval);

                Send(new HeartbeatPayload
                {
                    SequenceNumber = sequenceNumber
                });
            }
        }

        public void Open()
        {
            socket.Open();
        }

        public void Send(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);

            Console.WriteLine(json);

            byte[] payload = Encoding.UTF8.GetBytes(json);
            socket.Send(payload, 0, payload.Length);
        }
    }
}
