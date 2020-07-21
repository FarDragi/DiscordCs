using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Activity
{
    internal class DiscordActivityParty
    {
        [JsonProperty("id")]
        internal string Id { get; set; }

        [JsonProperty("size")]
        internal uint[] Size { get; set; }
    }
}
