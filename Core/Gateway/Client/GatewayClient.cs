using FarDragi.DragiCordApi.Core.Gateway.Codes;
using FarDragi.DragiCordApi.Core.Gateway.Models.Identify;
using FarDragi.DragiCordApi.Core.Gateway.Models.Payloads;
using FarDragi.DragiCordApi.Core.Gateway.Workers;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace FarDragi.DragiCordApi.Core.Gateway.Client
{
    internal sealed class GatewayClient : IDisposable
    {
        private GatewayWebSocket _socket = null;
        private IdentifyGateway _identify = null;

        internal GatewayClient(IdentifyGateway identify)
        {
            _identify = identify;
        }

        internal async Task Connect()
        {
            _socket = new GatewayWebSocket(string.Format(GatewayConfig.GatewayUrl, GatewayConfig.ApiVersion, GatewayConfig.Encoding));
            _socket.SocketOpened += Socket_SocketOpened;
            _socket.SocketDataReceived += Socket_SocketDataReceived;
            _socket.SocketMessageReceived += Socket_SocketMessageReceived;
            await _socket.Connect();
        }

        private Task Socket_SocketMessageReceived(string e)
        {
            JObject json = JObject.Parse(e);
            UpdateSessionCode(json);
            GatewayOpcode opcode = (GatewayOpcode)Convert.ToByte(json["op"].ToString());

            Console.WriteLine($"[DataReceived]\n\n{e}\n\n");


            switch (opcode)
            {
                case GatewayOpcode.Dispatch:
                    new DispatchWorker(this, json);
                    break;
                case GatewayOpcode.Hello:
                    new HeartbeatWorker(ref _socket);
                    break;
                default:
                    break;
            }

            return Task.CompletedTask;
        }

        private Task Socket_SocketDataReceived(string e)
        {
            JObject json = JObject.Parse(e);
            UpdateSessionCode(json);
            GatewayOpcode opcode = (GatewayOpcode)Convert.ToByte(json["op"].ToString());

            Console.WriteLine($"[DataReceived]\n\n{json.ToString()}\n\n");


            switch (opcode)
            {
                case GatewayOpcode.Dispatch:
                    new DispatchWorker(this, json);
                    break;
                case GatewayOpcode.Hello:
                    new HeartbeatWorker(ref _socket);
                    break;
                default:
                    break;
            }

            return Task.CompletedTask;
        }

        private Task Socket_SocketOpened(EventArgs e)
        {
            _socket.SendMessage(new PayloadSend<IdentifyGateway>
            {
                Opcode = GatewayOpcode.Identify,
                Data = _identify
            });
            Console.WriteLine("Connect");
            return Task.CompletedTask;
        }

        internal void UpdateSessionCode(JObject json)
        {
            if (ulong.TryParse(json["s"].ToString(), out ulong result))
            {
                _socket.SessionCode = result;
            }
        }

        public void Dispose()
        {
            _socket.Dispose();
        }
    }
}
