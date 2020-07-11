using FarDragi.DragiCordApi.Core.Base.Models.Base;

namespace FarDragi.DragiCordApi.Core.Base.Client
{
    public class DiscordClientConfig
    {
        public string Token { get; set; }
        public DiscordShards Shards { get; set; }
    }
}
