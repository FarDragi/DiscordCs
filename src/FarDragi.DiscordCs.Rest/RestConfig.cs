using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Rest
{
    public class RestConfig
    {
        public const string BaseUrl = "https://discord.com/api/v{0}";
        public int Version { get; set; }

        public string Url
        {
            get
            {
                return string.Format(BaseUrl, Version);
            }
        }
    }
}
