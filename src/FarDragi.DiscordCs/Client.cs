using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Collections;
using FarDragi.DiscordCs.Entities.GuildModels;
using FarDragi.DiscordCs.Gateway;
using FarDragi.DiscordCs.Gateway.Attributes;
using FarDragi.DiscordCs.Gateway.Interfaces;
using FarDragi.DiscordCs.Json.Entities.GuildModels;
using FarDragi.DiscordCs.Json.Entities.MessageModels;
using FarDragi.DiscordCs.Json.Entities.ReadyModels;
using FarDragi.DiscordCs.Rest;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs
{
    public delegate Task ClientEventHandler<TData>(Client client, ClientEventArgs<TData> args);

    public class Client : IGatewayEvents
    {
        private readonly ClientConfig _config;
        private readonly List<GatewayClient> _gateways;
        private RestClient _restClient;

        public event ClientEventHandler<string> Raw;
        public event ClientEventHandler<JsonReady> Ready;
        public event ClientEventHandler<Guild> GuildCreate;

        public readonly GuildCollection Guilds;
        public readonly UserCollection Users;

        public Client(ClientConfig clientConfig) : base()
        {
            _config = clientConfig;
            _gateways = new List<GatewayClient>();
            Guilds = new GuildCollection();
            Users = new UserCollection();
        }

        public async Task Login()
        {
            _restClient = new RestClient(new RestConfig
            {
                Token = _config.Token
            });

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

        public virtual void OnRawAsync(GatewayClient gateway, string data)
        {
            Raw?.Invoke(this, new ClientEventArgs<string>
            {
                Data = data,
                Gateway = gateway
            });
        }

        [GatewayEvent("READY", typeof(JsonReady))]
        public virtual void OnReady(GatewayClient gateway, object data)
        {
            if (data is JsonReady ready)
            {
                gateway.SessionId = ready.SessionId;
            }
        }

        [GatewayEvent("GUILD_CREATE", typeof(JsonGuild))]
        public virtual void OnGuildCreate(GatewayClient gateway, object data)
        {
            if (data is JsonGuild json)
            {
                Guild guild = new Guild
                {
                    Id = json.Id,
                    Name = json.Name
                };

                Guilds.Caching(guild);

                GuildCreate.Invoke(this, new ClientEventArgs<Guild>
                {
                    Data = guild,
                    Gateway = gateway
                });
            }
        }

        [GatewayEvent("MESSAGE_CREATE", typeof(JsonMessage))]
        public virtual void OnMessageCreate(GatewayClient gateway, object data)
        {
            
        }
    }
}
