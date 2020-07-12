using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base
{
    internal class DiscordActivityParty
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("size")]
        public uint[] Size { get; set; }
    }
}
