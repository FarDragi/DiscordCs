namespace FarDragi.DiscordCs.Core.Utils.Constants
{
    static public class WebsocketUrl
    {
        public const string BaseUrl = "wss://gateway.discord.gg/?v={0}&encoding={1}&compress=zlib-stream";
        public const string ApiVersion = "8";
        public const string Encoding = "json";

        public static string FinalUrl
        {
            get
            {
                return string.Format(BaseUrl, ApiVersion, Encoding);
            }
        }
    }
}
