using FarDragi.DiscordCs.Core.Models.Enums;

namespace FarDragi.DiscordCs.Core.Client
{
    public class ClientConfig
    {
        public string Token { get; init; }
        public int Shards { get; init; } = 1;
        public bool AutoShardConfig { get; set; } = true;
        public int[] Shard { get; set; }
        public Intents Intents { get; set; } = Intents.Default;

        public ClientConfig(string token)
        {
            Token = token;
        }
    }
}
