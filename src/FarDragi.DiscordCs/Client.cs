using FarDragi.DiscordCs.Gateway;
using FarDragi.DiscordCs.Gateway.Attributes;
using FarDragi.DiscordCs.Gateway.Interfaces;
using FarDragi.DiscordCs.Json.Entities.ReadyModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs
{
    public class Client : IGatewayEvents
    {
        private readonly ClientConfig config;
        private readonly List<GatewayClient> gateways;

        public event EventHandler<string> Raw;

        public Client(ClientConfig clientConfig) : base()
        {
            config = clientConfig;
            gateways = new List<GatewayClient>();
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
                if (config.Shard == null)
                {
                    // TODO nomear o erro
                    throw new ArgumentNullException();
                }

                GatewayClient client = new GatewayClient(this, config.GetIdentify(config.Shard));
                client.Open();
                gateways.Add(client);
            }
        }

        public virtual void OnRaw(GatewayClient sender, string data)
        {
        }

        [GatewayEvent("READY", typeof(JsonReady))]
        public virtual void OnReady(GatewayClient sender, object data)
        {
            if (data is JsonReady ready)
            {

            }
        }
    }
}
