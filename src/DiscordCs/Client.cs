﻿using FarDragi.DiscordCs.Args;
using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Interfaces;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Entity.Models.ReadyModels;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using FarDragi.DiscordCs.Gateway;
using FarDragi.DiscordCs.Logging;
using FarDragi.DiscordCs.Rest;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs
{
    public class Client : IGatewayEvents, IDatas
    {
        private ClientConfig _clientConfig;

        private IGatewayContext _gatewayContext;
        private ICacheContext _cacheContext;
        private IRestContext _restContext;

        public Client(ClientConfig clientConfig)
        {
            StartConfig(clientConfig);
        }

        public Client(string token)
        {
            StartConfig(new ClientConfig
            {
                Identify =
                {
                    Token = token
                }
            });
        }

        private void StartConfig(ClientConfig clientConfig)
        {
            _clientConfig = clientConfig;
            Logger = clientConfig.Logger;
            Logger.Log(LoggingLevel.Dcs, "DiscosCs v0.1-dev");
            InitCollections();
        }

        #region Login

        private async Task Init()
        {
            _gatewayContext = _clientConfig.GatewayContext;

            async Task Register(Identify identify)
            {
                await _gatewayContext.AddClient(identify);
            }

            if (_clientConfig.IsAutoSharding)
            {
                _gatewayContext.Init(_clientConfig.Shards, this, Logger, _cacheContext, this);

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
                _gatewayContext.Init(1, this, Logger, _cacheContext, this);

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

        #region Datas

        public User User { get; private set; }
        public ILogger Logger { get; set; }
        public GuildCollection Guilds { get; private set; }
        public UserCollection Users { get; private set; }
        public GuildChannelsCollection Channels { get; private set; }

        public void InitCollections()
        {
            _cacheContext = _clientConfig.CacheContext;
            Guilds = new GuildCollection(_cacheContext.GetCache<ulong, Guild>());
            Users = new UserCollection(_cacheContext.GetCache<ulong, User>());
            Channels = new GuildChannelsCollection(_cacheContext.GetCache<ulong, GuildChannel>());
        }

        #endregion

        #region Events

        public delegate Task ClientEventHandler<TEntity>(Client client, ClientArgs<TEntity> args);

        public event ClientEventHandler<string> Raw;
        public event ClientEventHandler<Ready> Ready;
        public event ClientEventHandler<Guild> GuildCreate;

        public virtual async void OnRaw(IGatewayClient gatewayClient, string json)
        {
            await Task.Yield();

            Raw?.Invoke(this, new ClientArgs<string>
            {
                GatewayClient = gatewayClient,
                Data = json
            });
        }

        public virtual async void OnReady(IGatewayClient gatewayClient, Ready ready)
        {
            await Task.Yield();

            gatewayClient.SessionId = ready.SessionId;
            User user = ready.User;
            Users.Caching(ref user);
            User = user;

            Ready?.Invoke(this, new ClientArgs<Ready>
            {
                GatewayClient = gatewayClient,
                Data = ready
            });
        }

        public virtual async void OnGuildCreate(IGatewayClient gatewayClient, Guild guild)
        {
            await Task.Yield();

            Guilds.Caching(ref guild);

            GuildCreate?.Invoke(this, new ClientArgs<Guild>
            {
                GatewayClient = gatewayClient,
                Data = guild
            });
        }

        #endregion
    }
}
