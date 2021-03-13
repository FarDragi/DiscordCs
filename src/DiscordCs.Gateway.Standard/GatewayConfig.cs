namespace FarDragi.DiscordCs.Gateway.Standard
{
    public class GatewayConfig
    {
        public const string UrlFormat = "{0}/?v={1}&encoding={2}&compress=zlib-stream";
        private int _version;
        private string _encoding;
        private string _baseUrl;

        public int Version { set => _version = value; }
        public string Encoding { set => _encoding = value; }
        public string BaseUrl { set => _baseUrl = value; }

        public string GetUrl()
        {
            return string.Format(UrlFormat, _baseUrl, _version, _encoding);
        }
    }
}
