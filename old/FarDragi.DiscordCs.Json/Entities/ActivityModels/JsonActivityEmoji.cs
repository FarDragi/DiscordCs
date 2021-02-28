using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Json.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-emoji
    /// </summary>
    public class JsonActivityEmoji
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public ulong? Id { get; set; }

        [JsonProperty("animated")]
        public bool Animated { get; set; }
    }
}
