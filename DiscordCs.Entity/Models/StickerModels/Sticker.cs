using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.StickerModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#message-object-message-sticker-structure
    /// </summary>
    public class Sticker
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("pack_id")]
        public ulong PackId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        [JsonPropertyName("asset")]
        public string Asset { get; set; }

        [JsonPropertyName("preview_asset")]
        public string PreviewAsset { get; set; }

        [JsonPropertyName("format_type")]
        public StickerFormatTypes FormatTypes { get; set; }
    }
}
