using Newtonsoft.Json;

namespace FarDragi.DragiCordApi.Core.Gateway.Models.Base
{
    public class DiscordActivityParty
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("size")]
        public uint[] Size { get; set; }
    }
}
