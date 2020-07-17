using FarDragi.DiscordCs.Core.Gateway.Models.Enumerators.Message;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Message
{
    internal class DiscordMessageActivity
    {
        [JsonProperty("type")]
        internal DiscordMessageActivityType Type { get; set; }

        [JsonProperty("party_id")]
        internal string PartyId { get; set; }
    }
}
