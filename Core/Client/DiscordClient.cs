using FarDragi.DragiCordApi.Core.Gateway.Client;
using FarDragi.DragiCordApi.Core.Gateway.Models.Identify;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DragiCordApi.Core.Client
{
    public class DiscordClient : IDisposable
    {
        private GatewayClient _gateway = null;

        public string Token { get; set; }
        public uint[] Shard { get; set; } = { 0, 1 };

        public DiscordClient()
        {

        }

        public async Task Connect()
        {
            IdentifyGateway identify = new IdentifyGateway
            {
                Token = Token,
                Properties = new IdentifyConnectionProperties
                {
                    Browser = "DragiCordApi",
                    Device = "Dragi",
                    OperatingSystem = Environment.OSVersion.Platform.ToString()
                },
                Compress = true,
                LargeThreshold = 50,
                GuildSubscriptions = false,
                Shard = Shard,
                Presence = new IdentifyPresence
                {
                    Since = 0,
                    Game = new IdentifyGame
                    {
                        Name = "Pitas gay",
                        Type = 0
                    },
                    Status = "online",
                    Afk = false
                },
                Intents = 32509
            };
            _gateway = new GatewayClient(identify);
            await _gateway.Connect();
        }

        public void Dispose()
        {
            _gateway.Dispose();
        }
    }
}
