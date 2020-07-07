using Newtonsoft.Json;

namespace FarDragi.DragiCordApi.Core.Gateway.Models.Identify
{
    internal sealed class IdentifyPresence
    {
        [JsonProperty("since")]
        internal uint Since { get; set; }
        [JsonProperty("game")]
        internal IdentifyGame Game { get; set; }
        [JsonProperty("status")]
        internal string Status { get; set; }
        [JsonProperty("afk")]
        internal bool Afk { get; set; }
    }
}
