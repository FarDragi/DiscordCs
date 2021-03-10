using FarDragi.DiscordCs.Entity.Interfaces;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Entity.Models.ReadyModels;
using FarDragi.DiscordCs.Gateway;
using FarDragi.DiscordCs.Logging;
using Pastel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs
{
    public class Client : IGatewayEvents
    {
        private readonly ClientConfig _clientConfig;
        private readonly ILogger _logger;

        private IGatewayContext _gatewayContext;

        public Client(ClientConfig clientConfig)
        {
            _clientConfig = clientConfig;
            _logger = clientConfig.GetLogger();
            _logger.Log(LoggingLevel.Dcs, "DiscosCs v0.1-dev");
        }

        #region Login

        private async Task Init()
        {
            _gatewayContext = _clientConfig.GetGatewayContext();

            async Task Register(Identify identify)
            {
                await _gatewayContext.AddClient(identify);
            }

            if (_clientConfig.IsAutoSharding)
            {
                _gatewayContext.Init(_clientConfig.Shards, this, _logger);

                for (int i = 0; i < _clientConfig.Shards; i++)
                {
                    await Register(_clientConfig.GetIdentify(new int[]
                    {
                        i,
                        _clientConfig.Shards
                    }));
                    await Task.Delay(6000);
                }
            }
            else
            {
                _gatewayContext.Init(1, this, _logger);

                await Register(_clientConfig.GetIdentify(_clientConfig.Shard));
            }
        }

        public async Task LoginAsync()
        {
            await Init();
        }

        public async Task Login()
        {
            await Init();
            await Task.Delay(-1);
        }

        #endregion

        #region Events

        public delegate Task ClientEventHandler<TEntity>(object sender, TEntity entity);

        public event ClientEventHandler<string> Raw;
        public event ClientEventHandler<Ready> Ready;
        public event ClientEventHandler<Guild> GuildCreate;

        public virtual async void OnRaw(IGatewayClient gatewayClient, string json)
        {
            await Task.Yield();

            Raw?.Invoke(gatewayClient, json);
        }

        public virtual async void OnReady(IGatewayClient gatewayClient, Ready ready)
        {
            await Task.Yield();

            Ready?.Invoke(gatewayClient, ready);
        }

        public virtual async void OnGuildCreate(IGatewayClient gatewayClient, Guild guild)
        {
            await Task.Yield();

            GuildCreate?.Invoke(gatewayClient, guild);
        }

        #endregion
    }
}
