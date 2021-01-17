using Newtonsoft.Json.Linq;

namespace FarDragi.DiscordCs.Gateway.Interfaces
{
    public interface IGatewayEvents
    {
        public void OnRaw(object sender, JObject data);
    }
}
