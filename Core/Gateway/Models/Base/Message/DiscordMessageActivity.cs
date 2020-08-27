using FarDragi.DiscordCs.Core.Gateway.Models.Enums.Message;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Message
{
    internal class DiscordMessageActivity
    {
        // Discord DiscordMessageActivity
        [JsonProperty("type")]
        internal DiscordMessageActivityType Type { get; set; }

        // Discord DiscordMessageActivity
        [JsonProperty("party_id")]
        internal string PartyId { get; set; }
    }
}
