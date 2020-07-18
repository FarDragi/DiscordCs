using FarDragi.DiscordCs.Core.Models.Base.Bot;

namespace FarDragi.DiscordCs.Core.Client
{
    public class DiscordClientConfig
    {
        public string Token { get; set; }
        public DiscordShards Shards { get; set; }
    }
}
