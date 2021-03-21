using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Rest.Standard
{
    public class RestConfig : IRestConfig
    {
        private const string UrlFormat = "{0}/api/v{1}";

        public string Type { get; set; } = "Bot";
        public int Version { get; set; }
        public string BaseUrl { get; set; }
        public string Token { get; set; }

        public string Url
        {
            get
            {
                return string.Format(UrlFormat, BaseUrl, Version);
            }
        }
    }
}
