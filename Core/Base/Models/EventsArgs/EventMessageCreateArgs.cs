using FarDragi.DiscordCs.Core.Base.Models.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Base.Models.EventsArgs
{
    public class EventMessageCreateArgs
    {
        public MessageCreate Data { get; }

        internal EventMessageCreateArgs(MessageCreate messageCreate)
        {
            Data = messageCreate;
        }
    }
}
