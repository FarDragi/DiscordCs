using FarDragi.DiscordCs.Core.Base.Models.Base;
using FarDragi.DiscordCs.Core.Base.Models.EventsArgs;
using FarDragi.DiscordCs.Core.Gateway.Client;
using FarDragi.DiscordCs.Core.Gateway.Models.EventsArgs;
using FarDragi.DiscordCs.Core.Gateway.Models.Identify;
using System;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Core.Base.Client
{
    public class DiscordClient : IDisposable
    {
        #region Data

        public DiscordUser User { get; internal set; }
        public DiscordGuild[] Guilds { get; internal set; }

        #endregion

        #region Configs

        private readonly GatewayClient _gatewayClient;
        private readonly IdentifyGateway _identifyGateway;

        public DiscordClient(DiscordClientConfig clientConfig)
        {
            _identifyGateway = new IdentifyGateway
            {
                Token = clientConfig.Token,
                Properties = new IdentifyConnectionProperties
                {
                    Browser = "DiscordCs",
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
            _gatewayClient.GuildCreate += OnEventGuildCreate;
        }

        public async Task Connect()
        {
            await _gatewayClient.Connect();
        }

        public void Dispose()
        {
            _gatewayClient.Dispose();
        }

        #endregion

        #region Events

        public delegate Task HandlerEventReady(EventReadyArgs e);
        public delegate Task HandlerEventGuildCreate(EventGuildCreateArgs e);

        public event HandlerEventReady Ready;
        public event HandlerEventGuildCreate GuildCreate;

        internal Task OnEventReady(GatewayEventReadyArgs e)
        {
            User = e.Data.User;
            Ready?.Invoke(new EventReadyArgs(e.Data));
            return Task.CompletedTask;
        }

        internal Task OnEventGuildCreate(GatewayEventGuildCreateArgs e)
        {
            GuildCreate?.Invoke(new EventGuildCreateArgs(e.Data));
            return Task.CompletedTask;
        }

        #endregion
    }
}
