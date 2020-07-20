using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Base.Channel
{
    public class DiscordVoiceChannel : DiscordChannel
    {
        public uint Bitrate { get; set; }
        public uint UserLimit { get; set; }
    }
}
