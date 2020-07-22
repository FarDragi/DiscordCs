using FarDragi.DiscordCs.Core.Models.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Base.Guild
{
    public class DiscordGuildChannels
    {
        public DiscordCategoryChannelList CategoryChannels { get; set; }
        public DiscordTextChannelList TextChannels { get; set; }
        public DiscordVoiceChannelList VoiceChannels { get; set; }
    }
}
