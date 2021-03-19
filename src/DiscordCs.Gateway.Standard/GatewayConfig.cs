namespace FarDragi.DiscordCs.Gateway.Standard
{
    public class GatewayConfig : IGatewayConfig
    {
        public const string UrlFormat = "{0}/?v={1}&encoding={2}&compress=zlib-stream";

        public int Version { get; set; }
        public string Encoding { get; set; }
        public string BaseUrl { get; set; }

        public string GetUrl()
        {
            return string.Format(UrlFormat, BaseUrl, Version, Encoding);
        }
    }
}
