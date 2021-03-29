using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.MessageModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#message-object-message-activity-structure
    /// </summary>
    public class MessageActivity
    {
        [JsonPropertyName("type")]
        public MessageActivityTypes MyProperty { get; set; }

        [JsonPropertyName("party_id")]
        public string PartyId { get; set; }
    }
}
