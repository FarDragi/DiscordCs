﻿using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Entities.EmbedModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#embed-object-embed-video-structure
    /// </summary>
    public class EmbedVideo
    {
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
