using FarDragi.DragiCordApi.Core.Base.Models.Base;
using FarDragi.DragiCordApi.Core.Gateway.Client;
using FarDragi.DragiCordApi.Core.Gateway.Models.Identify;
using System;
using System.Threading.Tasks;

namespace FarDragi.DragiCordApi.Core.Base.Client
{
    public class DiscordClient : DiscordClientEvents, IDisposable
    {
        private readonly GatewayClient _gatewayClient;
        private readonly IdentifyGateway _identifyGateway;

        public DiscordClient(DiscordClientConfig clientConfig)
        {
            _identifyGateway = new IdentifyGateway
            {
                Token = clientConfig.Token,
                Properties = new IdentifyConnectionProperties
                {
                    Browser = "DragiCordApi",
                    Device = Environment.MachineName,
                    OperatingSystem = Environment.OSVersion.Platform.ToString()
                },
                Compress = true,
                LargeThreshold = 50,
                GuildSubscriptions = false,
                Intents = 32509
            };

            if (clientConfig.Shards != null)
            {
                _identifyGateway.Shards = new uint[] { clientConfig.Shards.ShardId, clientConfig.Shards.ShardCount };
            }

            // TODO game acitity

            _gatewayClient = new GatewayClient(_identifyGateway);
            _gatewayClient.Ready += OnEventReady;
        }

        public async Task Connect()
        {
            await _gatewayClient.Connect();
        }

        public void Dispose()
        {
            _gatewayClient.Dispose();
        }
    }
}
