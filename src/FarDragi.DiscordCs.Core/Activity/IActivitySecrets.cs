using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Activity
{
    public interface IActivitySecrets
    {
        public string Join { get; set; }
        public string Spectate { get; set; }
        public string Match { get; set; }
    }
}
