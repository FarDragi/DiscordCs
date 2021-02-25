using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Entities.MessageModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#message-object-message-activity-structure
    /// </summary>
    public class MessageActivity
    {
        [JsonProperty("type")]
        public MessageActivityTypes MyProperty { get; set; }

        [JsonProperty("party_id")]
        public string PartyId { get; set; }
    }
}
