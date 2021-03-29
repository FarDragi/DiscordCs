using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.EmbedModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#embed-object-embed-structure
    /// </summary>
    public class Embed
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }

        [JsonPropertyName("color")]
        public int Color { get; set; }

        [JsonPropertyName("footer")]
        public EmbedFooter Footer { get; set; }

        [JsonPropertyName("image")]
        public EmbedImage Image { get; set; }

        [JsonPropertyName("thumbnail")]
        public EmbedThumbnail Thumbnail { get; set; }

        [JsonPropertyName("video")]
        public EmbedVideo Video { get; set; }

        [JsonPropertyName("provider")]
        public EmbedProvider Provider { get; set; }

        [JsonPropertyName("author")]
        public EmbedAuthor Author { get; set; }

        [JsonPropertyName("Embed Field")]
        public EmbedField[] Fields { get; set; }
    }
}
