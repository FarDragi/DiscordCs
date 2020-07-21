using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Activity
{
    internal class DiscordActivityTimestamp
    {
        [JsonProperty("start")]
        internal ulong Start { get; set; }

        [JsonProperty("end")]
        internal ulong End { get; set; }
    }
}
