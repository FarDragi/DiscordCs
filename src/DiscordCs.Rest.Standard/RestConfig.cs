using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Rest.Standard
{
    public class RestConfig : IRestConfig
    {
        private const string UrlFormat = "{0}/api/v{1}";
        private string _type = "Bot";
        private int _version;
        private string _baseUrl;

        public string Type { set => _type = value; }
        public int Version { set => _version = value; }
        public string BaseUrl { set => _baseUrl = value; }

        public string Url
        {
            get
            {
                return string.Format(UrlFormat, _baseUrl, _version);
            }
        }

        public string GetToken(string token)
        {
            return _type + " " + token;
        }
    }
}
