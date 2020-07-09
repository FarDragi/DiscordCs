using FarDragi.DragiCordApi.Core.Gateway.Models.Enumerators;
using Newtonsoft.Json;

namespace FarDragi.DragiCordApi.Core.Gateway.Models.Base
{
    internal class DiscordChannelOverrites
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("allow")]
        public DiscordPermissions Allow { get; set; }

        [JsonProperty("deny")]
        public DiscordPermissions Deny { get; set; }
    }
}