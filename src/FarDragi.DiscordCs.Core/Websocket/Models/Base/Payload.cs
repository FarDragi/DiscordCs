using FarDragi.DiscordCs.Core.Websocket.Models.Codes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FarDragi.DiscordCs.Core.Websocket.Models.Base
{
    public class Payload<TData>
    {
        [JsonProperty("op")]
        public GatewayOpcode Opcode { get; set; }

        [JsonProperty("d")]
        public TData Data { get; set; }

        [JsonProperty("s")]
        public int? Session { get; set; }

        [JsonProperty("t")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GatewayEvents? EventName { get; set; }
    }
}
