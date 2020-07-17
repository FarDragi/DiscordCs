using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed
{
    internal class DiscordFooter
    {
        [JsonProperty("text")]
        internal string Text { get; set; }

        [JsonProperty("icon_url")]
        internal string IconUrl { get; set; }
    }
}
