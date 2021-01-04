using FarDragi.DiscordCs.Core.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Ready
{
    interface IDiscordReady
    {
        public int Vesion { get; set; }
        public IDiscordUser User { get; set; }
    }
}
