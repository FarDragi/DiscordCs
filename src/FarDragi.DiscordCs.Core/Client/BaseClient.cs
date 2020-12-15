using FarDragi.DiscordCs.Core.Websocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Core.Client
{
    public class BaseClient
    {
        public readonly DiscordWebsocket Websocket;
        public ConfigClient Config { get; init; }

        public BaseClient(ConfigClient config)
        {
            Config = config;
            Websocket = new DiscordWebsocket(this);
        }
    }
}
