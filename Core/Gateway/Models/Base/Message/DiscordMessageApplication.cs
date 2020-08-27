using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Message
{
    internal class DiscordMessageApplication
    {
        // Discord DiscordMessageApplication
        [JsonProperty("id")]
        internal ulong Id { get; set; }

        // Discord DiscordMessageApplication
        [JsonProperty("cover_image")]
        internal string CoverImage { get; set; }

        // Discord DiscordMessageApplication
        [JsonProperty("description")]
        internal string Description { get; set; }

        // Discord DiscordMessageApplication
        [JsonProperty("icon")]
        internal string Icon { get; set; }

        // Discord DiscordMessageApplication
        [JsonProperty("name")]
        internal string Name { get; set; }
    }
}
