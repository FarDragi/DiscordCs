using FarDragi.DiscordCs.Gateway;
using FarDragi.DiscordCs.Gateway.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

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

        public void Login()
        {
            if (config.AutoSharding)
            {
                for (int i = 0; i < config.Shards; i++)
                {
                    GatewayClient client = new GatewayClient(this, config.GetIdentify(new int[] { i, (int)config.Shards }));
                    client.Open();
                    gateways.Add(client);
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

        public virtual void OnRaw(object sender, JObject data)
        {
        }
    }
}
