using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Entities.MessageModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#message-object-message-application-structure
    /// </summary>
    public class MessageApplication
    {
        [JsonProperty("id")]
        public ulong MyProperty { get; set; }

        [JsonProperty("cover_image")]
        public string CoverImage { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
