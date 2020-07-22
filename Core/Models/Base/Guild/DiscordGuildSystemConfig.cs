using FarDragi.DiscordCs.Core.Models.Enums.Guild;

namespace FarDragi.DiscordCs.Core.Models.Base.Guild
{
    public class DiscordGuildSystemConfig
    {
        public ulong? SystemChannelId { get; set; }
        public DiscordGuildSystemChannelFlags SystemChannelFlags { get; set; }
    }
}
