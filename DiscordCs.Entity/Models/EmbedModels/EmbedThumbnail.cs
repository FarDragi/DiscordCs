using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.EmbedModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#embed-object-embed-thumbnail-structure
    /// </summary>
    public class EmbedThumbnail
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("proxy_url")]
        public string ProxyUrl { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }
    }
}
