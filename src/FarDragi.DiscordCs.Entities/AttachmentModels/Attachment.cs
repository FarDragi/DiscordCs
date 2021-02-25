using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Entities.AttachmentModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#attachment-object-attachment-structure
    /// </summary>
    public class Attachment
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("proxy_url")]
        public string ProxyUrl { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }
    }
}
