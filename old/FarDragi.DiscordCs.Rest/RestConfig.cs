namespace FarDragi.DiscordCs.Rest
{
    public class RestConfig
    {
        public string Token { get; set; }

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
