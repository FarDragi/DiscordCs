using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Rest
{
    public interface IRestConfig
    {
        public string Type { get; set; }
        public int Version { get; set; }
        public string BaseUrl { get; set; }
        public string Token { get; set; }
    }
}
