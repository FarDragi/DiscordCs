using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Base.Guild
{
    public class DiscordGuildWidgetConfig
    {
        public ulong? WidgetChannelId { get; set; }
        public bool WidgetEnabled { get; set; }
    }
}
