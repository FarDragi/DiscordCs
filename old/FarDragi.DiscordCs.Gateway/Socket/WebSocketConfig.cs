namespace FarDragi.DiscordCs.Gateway.Socket
{
    public class WebSocketConfig
    {
        public const string BaseUrl = "wss://gateway.discord.gg/?v={0}&encoding={1}&compress=zlib-stream";
        public int Version { get; set; }
        public string Encoding { get; set; }

        public string Url
        {
            get
            {
                return string.Format(BaseUrl, Version, Encoding);
            }
        }
    }
}
