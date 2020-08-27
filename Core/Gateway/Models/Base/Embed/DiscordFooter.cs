using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed
{
    internal class DiscordFooter
    {
        // Discord Footer
        [JsonProperty("text")]
        internal string Text { get; set; }

        // Discord Footer
        [JsonProperty("icon_url")]
        internal string IconUrl { get; set; }
    }
}
