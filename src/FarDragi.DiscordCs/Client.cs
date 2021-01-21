using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entities.GuildModels;
using FarDragi.DiscordCs.Gateway;
using FarDragi.DiscordCs.Gateway.Attributes;
using FarDragi.DiscordCs.Gateway.Interfaces;
using FarDragi.DiscordCs.Json.Entities.GuildModels;
using FarDragi.DiscordCs.Json.Entities.ReadyModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs
{
    public delegate Task ClientEventHandler<TData>(Client client, ClientEventArgs<TData> args);

    public class Client : IGatewayEvents
    {
        private readonly ClientConfig config;
        private readonly List<GatewayClient> gateways;

        public event ClientEventHandler<string> Raw;
        public event ClientEventHandler<JsonReady> Ready;
        public event ClientEventHandler<Guild> GuildCreate;

        public readonly GuildCache Guilds;
        public readonly UserCache Users;

        public Client(ClientConfig clientConfig) : base()
        {
            config = clientConfig;
            gateways = new List<GatewayClient>();
            Guilds = new GuildCache(this);
        }

        public async void Login()
        {
            if (config.AutoSharding)
            {
                for (int i = 0; i < config.Shards; i++)
                {
                    GatewayClient client = new GatewayClient(this, config.GetIdentify(new int[] { i, (int)config.Shards }));
                    client.Open();
                    gateways.Add(client);
                    await Task.Delay(6000);
                }
            }
            else
            {
                GatewayClient client = new GatewayClient(this, config.GetIdentify(config.Shard));
                client.Open();
                gateways.Add(client);
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
    }
}
