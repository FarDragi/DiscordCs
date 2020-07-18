using FarDragi.DiscordCs.Core.Base.Models.Base.User;
using FarDragi.DiscordCs.Core.Base.Models.Collections;
using FarDragi.DiscordCs.Core.Base.Models.EventsArgs;
using FarDragi.DiscordCs.Core.Gateway.Client;
using FarDragi.DiscordCs.Core.Gateway.Models.EventsArgs;
using FarDragi.DiscordCs.Core.Gateway.Models.Identify;
using FarDragi.DiscordCs.Core.Rest.Client;
using FarDragi.DiscordCs.Core.Rest.Models.Identify;
using System;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Core.Base.Client
{
    public class DiscordClient : IDisposable
    {
        #region Data

        public DiscordUser User { get; internal set; }
        public DiscordGuildList Guilds { get; }

        #endregion

        #region Configs

        private readonly GatewayClient _gatewayClient;
        private readonly IdentifyGateway _identifyGateway;
        private readonly RestClient _restClient;
        private readonly IdentifyRest _identifyRest;

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

            _identifyRest = new IdentifyRest
            {
                Token = clientConfig.Token
            };

            // TODO game acitity
            Guilds = new DiscordGuildList(_restClient);

            _restClient = new RestClient(_identifyRest);

            _gatewayClient = new GatewayClient(_identifyGateway);
            _gatewayClient.Ready += OnEventReady;
            _gatewayClient.GuildCreate += OnEventGuildCreate;
            _gatewayClient.MessageCreate += OnEventMessageCreate;
        }

        public async Task Connect()
        {
            await _gatewayClient.Connect();
        }

        public void Dispose()
        {
            _gatewayClient.Dispose();
            _restClient.Dispose();
        }

        #endregion

        #region Events

        public delegate Task HandlerEventReady(EventReadyArgs e);
        public delegate Task HandlerEventGuildCreate(EventGuildCreateArgs e);
        public delegate Task HandlerEventMessageCreate(EventMessageCreateArgs e);

        public event HandlerEventReady Ready;
        public event HandlerEventGuildCreate GuildCreate;
        public event HandlerEventMessageCreate MessageCreate;

        internal void OnEventReady(GatewayEventReadyArgs e)
        {
            User = e.Data.User;
            Ready?.Invoke(new EventReadyArgs(e.Data));
        }

        internal void OnEventGuildCreate(GatewayEventGuildCreateArgs e)
        {
            Guilds.Add(e.Data);
            GuildCreate?.Invoke(new EventGuildCreateArgs(e.Data));
        }

        internal void OnEventMessageCreate(GatewayEventMessageCreateArgs e)
        {
            MessageCreate?.Invoke(new EventMessageCreateArgs(e.Data));
        }

        #endregion
    }
}
