using FarDragi.DiscordCs.Core.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Core.Websocket
{
    public class DiscordWebsocket : BaseWebsocket, IDisposable
    {
        public BaseClient BaseClient { get; }

        public DiscordWebsocket(BaseClient baseClient) : base(baseClient.Config.ConfigWebsocket)
        {
            BaseClient = baseClient;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
