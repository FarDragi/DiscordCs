using FarDragi.DiscordCs.Core.Models.Enumerators.Guild;

namespace FarDragi.DiscordCs.Core.Models.Base.Guild
{
    public class DiscordGuildConfig
    {
        public DiscordGuildVerificationLevel VerificationLevel { get; set; }
        public DiscordGuildMessageNotificationLevel DefaultMessageNotification { get; set; }
        public DiscordGuildContentFilterLevel ExplicitContentFilter { get; set; }
        public DiscordGuildWidgetConfig WidgetConfig { get; set; }
        public DiscordGuildSystemConfig SystemConfig { get; set; }
        public DiscordGuildAfkConfig AfkConfig { get; set; }
        public DiscordGuildEmbedConfig EmbedConfig { get; set; }
    }
}
