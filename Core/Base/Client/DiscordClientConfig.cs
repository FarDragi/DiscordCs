using FarDragi.DiscordCs.Core.Base.Models.Base;

namespace FarDragi.DiscordCs.Core.Base.Client
{
    public class DiscordClientConfig
    {
        public string Token { get; set; }
        public DiscordShards Shards { get; set; }
    }
}
