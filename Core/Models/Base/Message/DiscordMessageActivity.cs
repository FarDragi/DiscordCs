using FarDragi.DiscordCs.Core.Models.Enums.Message;

namespace FarDragi.DiscordCs.Core.Models.Base.Message
{
    public class DiscordMessageActivity
    {
        public DiscordMessageActivityType Type { get; set; }
        public string PartyId { get; set; }
    }
}
