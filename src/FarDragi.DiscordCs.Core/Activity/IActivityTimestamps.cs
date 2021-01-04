using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Activity
{
    public interface IActivityTimestamps
    {
        public int Start { get; set; }
        public int End { get; set; }
    }
}
