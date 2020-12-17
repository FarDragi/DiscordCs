using FarDragi.DiscordCs.Core.Websocket.Models.Codes;
using Newtonsoft.Json;

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
        public string EventName { get; set; }
    }
}
