using FarDragi.DiscordCs.Core.Models.Enumerators.Guild;

namespace FarDragi.DiscordCs.Core.Models.Base.Guild
{
    public class DiscordGuildConfig
    {
        public DiscordGuildVerificationLevel VerificationLevel { get; set; }
        public DiscordGuildMessageNotificationLevel DefaultMessageNotification { get; set; }
        public DiscordGuildContentFilterLevel ExplicitContentFilter { get; set; }
    }
}
