using FarDragi.DiscordCs.Entity.Models.GuildModels;
using FarDragi.DiscordCs.Entity.Models.MessageModels;
using FarDragi.DiscordCs.Entity.Models.ReadyModels;

namespace FarDragi.DiscordCs.Gateway
{
    public interface IGatewayEvents
    {
        public void OnRaw(IGatewayClient gatewayClient, string json);
        public void OnReady(IGatewayClient gatewayClient, Ready ready);
        public void OnGuildCreate(IGatewayClient gatewayClient, Guild guild);
        public void OnMessageCreate(IGatewayClient gatewayClient, Message message);
        public void OnMessageUpdate(IGatewayClient gatewayClient, Message message);
        public void OnMessageDelete(IGatewayClient gatewayClient, Message message);
    }
}
