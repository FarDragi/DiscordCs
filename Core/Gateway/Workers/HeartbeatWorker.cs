using FarDragi.DragiCordApi.Core.Gateway.Client;
using FarDragi.DragiCordApi.Core.Gateway.Models.Payloads;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FarDragi.DragiCordApi.Core.Gateway.Workers
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
                _webSocket.SendMessage(new PayloadSend<int>
                {
                    Opcode = Codes.GatewayOpcode.Heartbeat,
                    Data = 20000
                });

                Thread.Sleep(20000);

            } while (true);
        }
    }
}
