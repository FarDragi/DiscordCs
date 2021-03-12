using FarDragi.DiscordCs.Caching;
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
    public class GatewayContext : IGatewayContext
    {
        private readonly GatewayConfig _config;
        private List<IGatewayClient> _clients;
        private ILogger _logger;
        private IGatewayEvents _events;
        private ICacheContext _cacheContext;

        public GatewayContext(GatewayConfig config)
        {
            _config = config;
        }

        public async Task AddClient(Identify identify)
        {
            IGatewayClient client = new GatewayClient(this, identify, _config, _logger, _cacheContext);
            await client.Open();
            _clients.Add(client);
        }

        public void Init(int shards, IGatewayEvents events, ILogger logger, ICacheContext cacheContext)
        {
            _clients = new List<IGatewayClient>(shards);
            _logger = logger;
            _events = events;
            _cacheContext = cacheContext;
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
