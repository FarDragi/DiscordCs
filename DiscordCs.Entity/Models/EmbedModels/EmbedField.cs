using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.EmbedModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#embed-object-embed-field-structure
    /// </summary>
    public class EmbedField
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("inline")]
        public bool? Inline { get; set; }
    }
}
