using Newtonsoft.Json;

namespace FarDragi.DragiCordApi.Core.Models
{
    public class DiscordActivityParty
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("size")]
        public uint[] Size { get; set; }
    }
}
