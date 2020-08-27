using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed
{
    internal class DiscordField
    {
        // Discord Field
        [JsonProperty("name")]
        internal string Name { get; set; }

        // Discord Field
        [JsonProperty("value")]
        internal string Value { get; set; }

        // Discord Field
        [JsonProperty("inline")]
        internal bool IsInline { get; set; }
    }
}
