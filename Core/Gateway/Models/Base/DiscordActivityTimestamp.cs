using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base
{
    internal class DiscordActivityTimestamp
    {
        [JsonProperty("start")]
        public ulong Start { get; set; }

        [JsonProperty("end")]
        public ulong End { get; set; }
    }
}
