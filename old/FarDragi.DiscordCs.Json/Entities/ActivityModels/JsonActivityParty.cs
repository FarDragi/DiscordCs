using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Json.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-party
    /// </summary>
    public class JsonActivityParty
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("size")]
        public int[] Size { get; set; }
    }
}
