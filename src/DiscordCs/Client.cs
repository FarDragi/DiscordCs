﻿using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Gateway;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs
{
    public class Client
    {
        private readonly ClientConfig _clientConfig;
        private List<IGatewayClient> _gateways;

        public Client(ClientConfig clientConfig)
        {
            _clientConfig = clientConfig;
        }

        #region Login

        private async Task Init()
        {
            IGatewayContext gatewayContext = _clientConfig.GetGatewayContext();

            async Task Register(Identify identify)
            {
                IGatewayClient gatewayClient = gatewayContext.GetClient(identify);
                await gatewayClient.Open();
                _gateways.Add(gatewayClient);
            }

            if (_clientConfig.IsAutoSharding)
            {
                _gateways = new List<IGatewayClient>(_clientConfig.Shards);

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
                _gateways = new List<IGatewayClient>(1);

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
    }
}