using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Embed
{
    internal class DiscordEmbed
    {
        // Discord Embed
        [JsonProperty("title")]
        internal string Title { get; set; }

        // Discord Embed
        [JsonProperty("type")]
        internal string Type { get; set; }

        // Discord Embed
        [JsonProperty("description")]
        internal string Description { get; set; }

        // Discord Embed
        [JsonProperty("url")]
        internal string Url { get; set; }

        // Discord Embed
        [JsonProperty("timestamp")]
        internal DateTime Timestamp { get; set; }

        // Discord Embed
        [JsonProperty("color")]
        internal uint Color { get; set; }

        // Discord Embed
        [JsonProperty("footer")]
        internal DiscordFooter Footer { get; set; }

        // Discord Embed
        [JsonProperty("image")]
        internal DiscordImage Image { get; set; }

        // Discord Embed
        [JsonProperty("thumbnail")]
        internal DiscordThumbnail Thumbnail { get; set; }

        // Discord Embed
        [JsonProperty("video")]
        internal DiscordVideo Video { get; set; }

        // Discord Embed
        [JsonProperty("provider")]
        internal DiscordProvider Provider { get; set; }

        // Discord Embed
        [JsonProperty("author")]
        internal DiscordAuthor Author { get; set; }

        // Discord Embed
        [JsonProperty("fields")]
        internal DiscordField[] Fields { get; set; }
    }
}
