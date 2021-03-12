using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Entity.Models.PayloadModels;
using FarDragi.DiscordCs.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Gateway
{
    public interface IGatewayContext
    {
        public Task AddClient(Identify identify);
        public void Init(int shards, IGatewayEvents events, ILogger logger, ICacheContext cacheContext);
        public void OnReceivedEvent(IGatewayClient gatewayClient, Payload<JsonElement> payload, string json, JsonSerializerOptions serializerOptions);
    }
}
