using FarDragi.DiscordCs.Gateway.Payloads;
using FarDragi.DiscordCs.Json.Entities.HelloModels;
using FarDragi.DiscordCs.Json.Entities.IdentifyModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SuperSocket.ClientEngine;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocket4Net;

namespace FarDragi.DiscordCs.Gateway.Socket
{
    public class WebSocketClient : IDisposable
    {
        private readonly WebSocket socket;
        private readonly WebSocketDecompress decompress;
        private readonly GatewayClient gatewayClient;
        private readonly JsonIdentify identify;

        private CancellationTokenSource tokenSource;
        private int? sequenceNumber;

        public WebSocketClient(GatewayClient gatewayClient, JsonIdentify identify)
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
            socket.MessageReceived += Socket_MessageReceived;
            socket.Error += Socket_Error;
            socket.Closed += Socket_Closed;
        }

        private void Socket_Closed(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            tokenSource.Dispose();
        }

        private void Socket_Error(object sender, ErrorEventArgs e)
        {
            tokenSource.Cancel();
            tokenSource.Dispose();
        }

        private void Socket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private void Socket_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (decompress.TryDecompress(e.Data, out string json))
            {
                Payload<JObject> payload = JsonConvert.DeserializeObject<Payload<JObject>>(json);
                sequenceNumber = payload.SequenceNumber;

                Console.WriteLine(json);
                Console.WriteLine();

                switch (payload.OpCode)
                {
                    case PayloadOpCode.Dispatch:
                        gatewayClient.OnEventReceived(payload.Event, payload.Data, json);
                        break;
                    case PayloadOpCode.Hello:
                        tokenSource = new CancellationTokenSource();
                        Heartbeat(payload.Data.ToObject<JsonHello>(), tokenSource.Token);
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

        public async void Heartbeat(JsonHello hello, CancellationToken token)
        {
            try
            {
                while (true)
                {
                    await Task.Delay(hello.HeartbeatInterval, token);
                    Send(new HeartbeatPayload
                    {
                        Data = sequenceNumber
                    });
                }
            }
            catch (Exception)
            {
                return;
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
            Console.WriteLine();

            byte[] payload = Encoding.UTF8.GetBytes(json);
            socket.Send(payload, 0, payload.Length);
        }

        public void Dispose()
        {
            socket.Dispose();
            if (tokenSource != null)
            {
                tokenSource.Dispose();
            }
        }
    }
}
