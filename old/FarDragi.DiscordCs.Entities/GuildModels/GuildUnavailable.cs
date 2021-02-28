using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Entities.GuildModels
{
    public class GuildUnavailable
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("unavailable")]
        public bool Unavailable { get; set; }
    }
}
