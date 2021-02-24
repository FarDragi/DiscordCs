using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.MessageModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#message-object-message-sticker-structure
    /// </summary>
    public class MessageSticker
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("pack_id")]
        public ulong PackId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("asset")]
        public string Asset { get; set; }

        [JsonProperty("preview_asset")]
        public string PreviewAsset { get; set; }

        [JsonProperty("format_type")]
        public MessageStickerFormatTypes FormatTypes { get; set; }
    }
}
