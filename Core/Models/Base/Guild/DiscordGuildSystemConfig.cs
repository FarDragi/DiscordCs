using FarDragi.DiscordCs.Core.Models.Enumerators.Guild;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Base.Guild
{
    public class DiscordGuildSystemConfig
    {
        public ulong? SystemChannelId { get; set; }
        public DiscordGuildSystemChannelFlags SystemChannelFlags { get; set; }
    }
}
