using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed
{
    internal class DiscordField
    {
        [JsonProperty("name")]
        internal string Name { get; set; }

        [JsonProperty("value")]
        internal string Value { get; set; }

        [JsonProperty("inline")]
        internal bool IsInline { get; set; }
    }
}
