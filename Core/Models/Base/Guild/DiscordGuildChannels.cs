using FarDragi.DiscordCs.Core.Models.Collections;

namespace FarDragi.DiscordCs.Core.Models.Base.Guild
{
    public class DiscordGuildChannels
    {
        public DiscordCategoryChannelList CategoryChannels { get; set; }
        public DiscordTextChannelList TextChannels { get; set; }
        public DiscordVoiceChannelList VoiceChannels { get; set; }
    }
}
