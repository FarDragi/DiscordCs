using FarDragi.DiscordCs.Core.Gateway.Codes;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Payloads
{
    internal sealed class PayloadSend<TData>
    {
        [JsonProperty("op")]
        internal GatewayOpcode Opcode { get; set; }
        [JsonProperty("d")]
        internal TData Data { get; set; }
    }
}
