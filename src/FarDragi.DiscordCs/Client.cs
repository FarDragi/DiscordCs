using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Caching.Standard;
using FarDragi.DiscordCs.Entities.ChannelModels;
using FarDragi.DiscordCs.Entities.GuildModels;
using FarDragi.DiscordCs.Entities.UserModels;
using FarDragi.DiscordCs.Gateway;
using FarDragi.DiscordCs.Gateway.Attributes;
using FarDragi.DiscordCs.Gateway.Interfaces;
using FarDragi.DiscordCs.Json.Entities.GuildModels;
using FarDragi.DiscordCs.Json.Entities.MessageModels;
using FarDragi.DiscordCs.Json.Entities.ReadyModels;
using FarDragi.DiscordCs.Rest;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs
{
    public delegate Task ClientEventHandler<TData>(Client client, ClientEventArgs<TData> args);

    public class Client : IGatewayEvents
    {
        private readonly ClientConfig _config;
        private readonly ICacheConfig _cacheConfig;
        private readonly List<GatewayClient> _gateways;
        private readonly RestClient _restClient;

        public event ClientEventHandler<string> Raw;
        public event ClientEventHandler<JsonReady> Ready;
        public event ClientEventHandler<Guild> GuildCreate;

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
        [GatewayEvent("READY", typeof(JsonReady))]
        public virtual void OnReadyJson(GatewayClient gateway, object data)
        {
            if (data is JsonReady ready)
            {
                gateway.SessionId = ready.SessionId;
            }
        }
        #endregion

        #region GuildCreate
        [GatewayEvent("GUILD_CREATE", typeof(JsonGuild))]
        public virtual async void OnGuildCreateJson(GatewayClient gateway, object data)
        {
            if (data is JsonGuild json)
            {
                Guild guild = json;

                guild.Channels = new ChannelCollection(_cacheConfig.GetCache<Channel>());

                Parallel.For(0, json.Channels.Length, i =>
                {
                    Channel channel = null;

                    switch ((ChannelTypes)json.Channels[i].Type)
                    {
                        case ChannelTypes.GuildText:
                            channel = (TextChannel)json.Channels[i];
                            break;
                        case ChannelTypes.GuildVoice:
                            channel = (VoiceChannel)json.Channels[i];
                            break;
                        case ChannelTypes.GuildCategory:
                            channel = (GuildCategory)json.Channels[i];
                            break;
                        case ChannelTypes.GuildNews:
                            channel = (GuildNews)json.Channels[i];
                            break;
                        case ChannelTypes.GuildStore:
                            channel = (GuildStore)json.Channels[i];
                            break;
                    }

                    channel.GuildId = guild.Id;

                    if (channel.ParentId != null)
                    {
                        channel.Parent = (GuildCategory)Channels[(ulong)channel.ParentId];
                    }

                    Channels.Caching(ref channel);
                    guild.Channels.Caching(ref channel);
                });

                Guilds.Caching(ref guild);

                await GuildCreate.Invoke(this, new ClientEventArgs<Guild>
                {
                    Data = guild,
                    Gateway = gateway
                });
            }
        }
        #endregion

        #region MessageCreate
        [GatewayEvent("MESSAGE_CREATE", typeof(JsonMessage))]
        public virtual void OnMessageCreateJson(GatewayClient gateway, object data)
        {

        }
        #endregion
    }
}
