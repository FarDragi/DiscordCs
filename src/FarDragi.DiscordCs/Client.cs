using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Caching.Standard;
using FarDragi.DiscordCs.Entities.ChannelModels;
using FarDragi.DiscordCs.Entities.GuildModels;
using FarDragi.DiscordCs.Entities.MessageModels;
using FarDragi.DiscordCs.Entities.PresenceModels;
using FarDragi.DiscordCs.Entities.ReadyModels;
using FarDragi.DiscordCs.Entities.UserModels;
using FarDragi.DiscordCs.Gateway;
using FarDragi.DiscordCs.Gateway.Attributes;
using FarDragi.DiscordCs.Gateway.Interfaces;
using FarDragi.DiscordCs.Rest;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs
{
    public class Client : IGatewayEvents
    {
        public delegate Task ClientEventHandler<TData>(Client client, ClientEventArgs<TData> args);

        private readonly ClientConfig _config;
        private readonly ICacheConfig _cacheConfig;
        private readonly List<GatewayClient> _gateways;
        private readonly RestClient _restClient;

        #region Events
        public event ClientEventHandler<string> Raw;
        public event ClientEventHandler<Ready> Ready;
        public event ClientEventHandler<Guild> GuildCreate;
        public event ClientEventHandler<Message> MessageCreate;
        public event ClientEventHandler<Message> MessageUpdate;
        public event ClientEventHandler<PresenceUpdateEvent> PresenceUpdate;
        #endregion

        public User User;
        public readonly GuildCollection Guilds;
        public readonly UserCollection Users;
        public readonly ChannelCollection Channels;

        public Client(ClientConfig clientConfig, ICacheConfig cacheConfig = null)
        {
            _config = clientConfig;
            _cacheConfig = cacheConfig ?? new StandardCacheConfig();
            _gateways = new List<GatewayClient>();
            _restClient = new RestClient(new RestConfig
            {
                Token = _config.Token
            });
            Guilds = new GuildCollection(_cacheConfig.GetCache<Guild>());
            Users = new UserCollection(_cacheConfig.GetCache<User>());
            Channels = new ChannelCollection(_cacheConfig.GetCache<Channel>());
        }

        private async void Init()
        {
            if (_config.AutoSharding)
            {
                for (int i = 0; i < _config.Shards; i++)
                {
                    GatewayClient client = new GatewayClient(this, _config.GetIdentify(new int[] { i, (int)_config.Shards }));
                    await client.Open();
                    _gateways.Add(client);
                    await Task.Delay(6000);
                }
            }
            else
            {
                GatewayClient client = new GatewayClient(this, _config.GetIdentify(_config.Shard));
                await client.Open();
                _gateways.Add(client);
            }
        }

        public void Login()
        {
            Init();
        }

        public async Task LoginAsync()
        {
            Init();
            await Task.Delay(-1);
        }

        public virtual void OnRaw(GatewayClient gateway, string data)
        {
            Raw?.Invoke(this, new ClientEventArgs<string>
            {
                Data = data,
                Gateway = gateway
            });
        }

        #region Ready
        [GatewayEvent("READY", typeof(Ready))]
        public virtual void OnReadyJson(GatewayClient gateway, object data)
        {
            if (data is Ready ready)
            {
                gateway.SessionId = ready.SessionId;
                User = ready.User;

                Users.Caching(ref User);

                Ready?.Invoke(this, new ClientEventArgs<Ready>
                {
                    Data = ready,
                    Gateway = gateway
                });
            }
        }
        #endregion

        #region Guild Create
        [GatewayEvent("GUILD_CREATE", typeof(Guild))]
        public virtual void OnGuildCreateJson(GatewayClient gateway, object data)
        {
            if (data is Guild guild)
            {
                guild.InitCaching(_cacheConfig, _restClient);
                guild.MemberCache(Users);
                guild.ChannelCache(_cacheConfig, _restClient, Channels);
                guild.RoleCache();
                guild.PresenceCache();

                Guilds.Caching(ref guild);

                GuildCreate?.Invoke(this, new ClientEventArgs<Guild>
                {
                    Data = guild,
                    Gateway = gateway
                });
            }
        }
        #endregion

        #region Message Create
        [GatewayEvent("MESSAGE_CREATE", typeof(Message))]
        public virtual void OnMessageCreateJson(GatewayClient gateway, object data)
        {
            if (data is Message message)
            {
                message.Channel = (TextChannel)Channels[message.ChannelId];
                message.Channel.Messages.Caching(ref message);

                MessageCreate?.Invoke(this, new ClientEventArgs<Message>
                {
                    Data = message,
                    Gateway = gateway
                });
            }
        }
        #endregion

        #region Message Update
        [GatewayEvent("MESSAGE_UPDATE", typeof(Message))]
        public virtual void OnMessageUpdateJson(GatewayClient gateway, object data)
        {
            if (data is Message message)
            {
                MessageUpdate?.Invoke(this, new ClientEventArgs<Message>
                {
                    Data = message,
                    Gateway = gateway
                });
            }
        }
        #endregion

        #region Presence Update
        [GatewayEvent("PRESENCE_UPDATE", typeof(PresenceUpdateEvent))]
        public virtual void OnPresenceUpdateJson(GatewayClient gateway, object data)
        {
            if (data is PresenceUpdateEvent presenceUpdate)
            {
                PresenceUpdate?.Invoke(this, new ClientEventArgs<PresenceUpdateEvent>
                {
                    Data = presenceUpdate,
                    Gateway = gateway
                });
            }
        }
        #endregion
    }
}
