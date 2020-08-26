using FarDragi.DiscordCs.Core.Gateway.Codes;
using FarDragi.DiscordCs.Core.Gateway.Models.EventsArgs;
using FarDragi.DiscordCs.Core.Gateway.Models.Identify;
using FarDragi.DiscordCs.Core.Gateway.Models.Payloads;
using FarDragi.DiscordCs.Core.Gateway.Workers;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Core.Gateway.Client
{
    internal sealed class GatewayClient : IDisposable
    {
        #region Configs

        private GatewayWebSocket _socket = null;
        private IdentifyGateway _identify = null;

        private DispatchWorker _dispatch = null;

        internal GatewayClient(IdentifyGateway identify)
        {
            _identify = identify;
            _dispatch = new DispatchWorker(this);
        }

        internal async Task Connect()
        {
            _socket = new GatewayWebSocket(string.Format(GatewayConfig.GatewayUrl, GatewayConfig.ApiVersion, GatewayConfig.Encoding));
            _socket.SocketOpened += Socket_SocketOpened;
            _socket.SocketDataReceived += Socket_SocketDataReceived;
            _socket.SocketMessageReceived += Socket_SocketMessageReceived;
            await _socket.Connect();
        }

        private async Task Socket_SocketMessageReceived(string e)
        {
            JObject json = JObject.Parse(e);
            UpdateSessionCode(json);
            GatewayOpcode opcode = (GatewayOpcode)Convert.ToByte(json["op"].ToString());

            switch (opcode)
            {
                case GatewayOpcode.Dispatch:
                    await _dispatch.Worker(json);
                    break;
                case GatewayOpcode.Hello:
                    new HeartbeatWorker(ref _socket);
                    break;
                default:
                    break;
            }
        }

        private async Task Socket_SocketDataReceived(string e)
        {
            JObject json = JObject.Parse(e);
            UpdateSessionCode(json);
            GatewayOpcode opcode = (GatewayOpcode)Convert.ToByte(json["op"].ToString());

            switch (opcode)
            {
                case GatewayOpcode.Dispatch:
                    await _dispatch.Worker(json);
                    break;
                case GatewayOpcode.Hello:
                    new HeartbeatWorker(ref _socket);
                    break;
                default:
                    break;
            }
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

        #endregion

        #region Events

        internal delegate void HandlerEventReady(GatewayEventReadyArgs e);
        internal delegate void HandlerEventGuildCrate(GatewayEventGuildCreateArgs e);
        internal delegate void HandlerEventMessageCreate(GatewayEventMessageCreateArgs e);

        internal event HandlerEventReady Ready;
        internal event HandlerEventGuildCrate GuildCreate;
        internal event HandlerEventMessageCreate MessageCreate;

        internal void OnEventReady(GatewayEventReadyArgs e)
        {
            Ready?.Invoke(e);
        }

        internal void OnEventGuildCreate(GatewayEventGuildCreateArgs e)
        {
            GuildCreate?.Invoke(e);
        }

        internal void OnEventMessageCreate(GatewayEventMessageCreateArgs e)
        {
            MessageCreate?.Invoke(e);
        }

        #endregion
    }
}
