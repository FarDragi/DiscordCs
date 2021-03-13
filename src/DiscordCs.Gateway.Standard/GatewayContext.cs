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
        private IDatas _datas;

        public GatewayContext(GatewayConfig config)
        {
            _config = config;
        }

        public async Task AddClient(Identify identify)
        {
            IGatewayClient client = new GatewayClient(this, identify, _config, _logger, _cacheContext, _datas);
            await client.Open();
            _clients.Add(client);
        }

        public void Init(int shards, IGatewayEvents events, ILogger logger, ICacheContext cacheContext, IDatas datas)
        {
            _clients = new List<IGatewayClient>(shards);
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _events = events ?? throw new ArgumentNullException(nameof(events));
            _cacheContext = cacheContext ?? throw new ArgumentNullException(nameof(cacheContext));
            _datas = datas ?? throw new ArgumentNullException(nameof(datas));
        }

        public void OnReceivedEvent(IGatewayClient gatewayClient, Payload<JsonElement> payload, string json, JsonSerializerOptions serializerOptions)
        {
            _events.OnRaw(gatewayClient, json);

            switch (payload.Event)
            {
                case "GUILD_CREATE":
                    var a = payload.Data.ToObject<Guild>(serializerOptions);
                    _events.OnGuildCreate(gatewayClient, a);
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
