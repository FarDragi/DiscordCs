using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Message
{
    internal class DiscordMessageApplication
    {
        [JsonProperty("id")]
        internal ulong Id { get; set; }

        [JsonProperty("cover_image")]
        internal string CoverImage { get; set; }

        [JsonProperty("description")]
        internal string Description { get; set; }

        [JsonProperty("icon")]
        internal string Icon { get; set; }

        [JsonProperty("name")]
        internal string Name { get; set; }
    }
}
