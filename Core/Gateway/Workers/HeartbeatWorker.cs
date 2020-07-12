using FarDragi.DiscordCs.Core.Gateway.Client;
using FarDragi.DiscordCs.Core.Gateway.Models.Payloads;
using System.Threading;

namespace FarDragi.DiscordCs.Core.Gateway.Workers
{
    internal sealed class HeartbeatWorker
    {
        private Thread _thread;
        private GatewayWebSocket _webSocket;

        internal HeartbeatWorker(ref GatewayWebSocket webSocket)
        {
            _webSocket = webSocket;
            _thread = new Thread(Worker);
            _thread.Start();
        }

        internal void Worker()
        {
            do
            {
                _webSocket.SendMessage(new PayloadSend<ulong>
                {
                    Opcode = Codes.GatewayOpcode.Heartbeat,
                    Data = _webSocket.SessionCode
                });

                Thread.Sleep(20000);

            } while (true);
        }
    }
}
