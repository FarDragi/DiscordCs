using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Message
{
    internal class DiscordMessageAttachment
    {
        // Discord Message Attachment
        [JsonProperty("id")]
        internal ulong Id { get; set; }

        // Discord Message Attachment
        [JsonProperty("filename")]
        internal string Filename { get; set; }

        // Discord Message Attachment
        [JsonProperty("size")]
        internal uint Size { get; set; }

        // Discord Message Attachment
        [JsonProperty("url")]
        internal string Url { get; set; }

        // Discord Message Attachment
        [JsonProperty("proxy_url")]
        internal string ProxyUrl { get; set; }

        // Discord Message Attachment
        [JsonProperty("height")]
        internal uint? Height { get; set; }

        // Discord Message Attachment
        [JsonProperty("width")]
        internal uint? Width { get; set; }
    }
}
