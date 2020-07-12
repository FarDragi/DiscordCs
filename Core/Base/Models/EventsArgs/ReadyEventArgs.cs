using FarDragi.DiscordCs.Core.Base.Models.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Base.Models.EventsArgs
{
    public class ReadyEventArgs
    {
        public Ready Data { get; set; }

        public ReadyEventArgs(Ready ready)
        {
            Data = ready;
        }
    }
}
