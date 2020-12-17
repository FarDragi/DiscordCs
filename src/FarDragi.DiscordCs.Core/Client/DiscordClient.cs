using FarDragi.DiscordCs.Core.Client.Interfaces;
using FarDragi.DiscordCs.Core.Jsons.Identify;
using FarDragi.DiscordCs.Core.Websocket;
using System;
using System.Collections.Generic;

namespace FarDragi.DiscordCs.Core.Client
{
    public class DiscordClient : IClient
    {
        private List<ClientBase> clients;

        public event IClientEvents.EventRaw Raw;

        public ClientConfig Config { get; init; }

        public DiscordClient(ClientConfig config)
        {
            Config = config;
        }

        public void OnRaw(string data)
        {
            Raw.Invoke(data);
        }

        public void Connect()
        {
            clients = new List<ClientBase>(Config.Shards);

            if (Config.AutoShardConfig)
            {
                for (int i = 0; i < Config.Shards; i++)
                {
                    DiscordIdentify identify = new();

                    identify.Token = Config.Token;
                    identify.Shard = new int[2] { i, Config.Shards };
                    identify.Intents = (int) Config.Intents;

                    clients.Add(new ClientBase(this, new WebsocketConfig()
                    {
                        Identify = identify
                    }));

                    clients[i].Connect();
                }
            }
            else
            {
                DiscordIdentify identify = new();

                identify.Token = Config.Token;
                identify.Shard = Config.Shard;
                identify.Intents = (int)Config.Intents;

                clients[0] = new ClientBase(this, new WebsocketConfig()
                {
                    Identify = identify
                });

                clients[0].Connect();
            }
        }
    }
}
