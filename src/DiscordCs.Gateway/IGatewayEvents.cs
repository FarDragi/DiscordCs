using FarDragi.DiscordCs.Entity.Interfaces;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using FarDragi.DiscordCs.Entity.Models.ReadyModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Gateway
{
    public interface IGatewayEvents
    {
        public void OnRaw(IGatewayClient gatewayClient, string json);
        public void OnReady(IGatewayClient gatewayClient, Ready ready);
        public void OnGuildCreate(IGatewayClient gatewayClient, Guild guild);
    }
}
