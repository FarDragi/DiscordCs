using FarDragi.DiscordCs.Core.Jsons.Identify;
using FarDragi.DiscordCs.Core.Websocket.Models.Base;
using FarDragi.DiscordCs.Core.Websocket.Models.Codes;

namespace FarDragi.DiscordCs.Core.Websocket.Models.Payloads
{
    public class GatewayIdentify : Payload<DiscordIdentify>
    {
        public GatewayIdentify(DiscordIdentify data)
        {
            Opcode = GatewayOpcode.Identify;
            Data = data;
        }
    }
}
