using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Interfaces;
using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Entity.Models.PayloadModels;
using FarDragi.DiscordCs.Logging;
using System.Text.Json;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Gateway
{
    public interface IGatewayContext
    {
        public Task AddClient(Identify identify);
        public void Init(int shards, IGatewayEvents events, ILogger logger, ICacheContext cacheContext, IDatas datas);
        public void OnReceivedEvent(IGatewayClient gatewayClient, Payload<JsonElement> payload, string json, JsonSerializerOptions serializerOptions);
    }
}
