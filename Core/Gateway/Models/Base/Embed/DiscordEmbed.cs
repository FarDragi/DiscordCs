using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed
{
    internal class DiscordEmbed
    {
        [JsonProperty("title")]
        internal string Title { get; set; }

        [JsonProperty("type")]
        internal string Type { get; set; }

        [JsonProperty("description")]
        internal string Description { get; set; }

        [JsonProperty("url")]
        internal string Url { get; set; }

        [JsonProperty("timestamp")]
        internal DateTime Timestamp { get; set; }

        [JsonProperty("color")]
        internal uint Color { get; set; }

        [JsonProperty("footer")]
        internal DiscordFooter Footer { get; set; }

        [JsonProperty("image")]
        internal DiscordImage Image { get; set; }

        [JsonProperty("thumbnail")]
        internal DiscordThumbnail Thumbnail { get; set; }

        [JsonProperty("video")]
        internal DiscordVideo Video { get; set; }

        [JsonProperty("provider")]
        internal DiscordProvider Provider { get; set; }

        [JsonProperty("author")]
        internal DiscordAuthor Author { get; set; }

        [JsonProperty("fields")]
        internal DiscordField[] Fields { get; set; }
    }
}
