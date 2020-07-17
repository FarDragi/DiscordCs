using FarDragi.DiscordCs.Core.Base.Models.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Base.Models.EventsArgs
{
    public class EventGuildCreateArgs
    {
        public GuildCreate Data { get; set; }

        public EventGuildCreateArgs(GuildCreate guildCreate)
        {
            Data = guildCreate;
        }
    }
}
