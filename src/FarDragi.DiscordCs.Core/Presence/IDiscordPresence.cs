using FarDragi.DiscordCs.Core.Activity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Presence
{
    public interface IDiscordPresence
    {
        public int Since { get; set; }
        public IDiscordActivity Activities { get; set; }
        public string Status { get; set; }
        public bool Afk { get; set; }
    }
}
