using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Rest
{
    public interface IRestConfig
    {
        public string Type { set; }
        public int Version { set; }
        public string BaseUrl { set; }
    }
}
