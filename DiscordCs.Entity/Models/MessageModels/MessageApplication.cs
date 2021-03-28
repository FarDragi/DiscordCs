using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.MessageModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#message-object-message-application-structure
    /// </summary>
    public class MessageApplication
    {
        [JsonPropertyName("id")]
        public ulong MyProperty { get; set; }

        [JsonPropertyName("cover_image")]
        public string CoverImage { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
