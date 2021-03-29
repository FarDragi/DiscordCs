using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.AttachmentModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#attachment-object-attachment-structure
    /// </summary>
    public class Attachment
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("filename")]
        public string Name { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }

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
