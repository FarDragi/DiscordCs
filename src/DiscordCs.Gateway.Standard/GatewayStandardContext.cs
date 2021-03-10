using FarDragi.DiscordCs.Entity.Converters;
using FarDragi.DiscordCs.Entity.Interfaces;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Entity.Models.PayloadModels;
using FarDragi.DiscordCs.Entity.Models.ReadyModels;
using FarDragi.DiscordCs.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Gateway.Standard
{
    public class GatewayStandardContext : IGatewayContext
    {
        private readonly GatewayStandardConfig _config;
        private List<IGatewayClient> _clients;
        private ILogger _logger;
        private IGatewayEvents _events;

        public event EventHandler<Ready> Ready;

        public GatewayStandardContext(GatewayStandardConfig config)
        {
            _config = config;
        }

        public async Task AddClient(Identify identify)
        {
            IGatewayClient client = new GatewayStandardClient(this, identify, _config, _logger);
            await client.Open();
            _clients.Add(client);
        }

        public void Init(int shards, IGatewayEvents events, ILogger logger)
        {
            _clients = new List<IGatewayClient>(shards);
            _logger = logger;
            _events = events;
        }

        public void OnReceivedEvent(IGatewayClient gatewayClient, Payload<JsonElement> payload, string json, JsonSerializerOptions serializerOptions)
        {
            _events.OnRaw(gatewayClient, json);

            switch (payload.Event)
            {
                case "GUILD_CREATE":
                    _events.OnGuildCreate(gatewayClient, payload.Data.ToObject<Guild>(serializerOptions));
                    break;
                case "READY":
                    _events.OnReady(gatewayClient, payload.Data.ToObject<Ready>(serializerOptions));
                    break;
                default:
                    break;
            }
        }
    }
}
