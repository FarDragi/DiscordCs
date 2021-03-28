using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-party
    /// </summary>
    public class ActivityParty
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("size")]
        public int[] Size { get; set; }
    }
}
