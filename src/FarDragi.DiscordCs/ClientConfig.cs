using FarDragi.DiscordCs.Entities.IdentifyModels;
using FarDragi.DiscordCs.Entities.PresenceModels;
using System;

namespace FarDragi.DiscordCs
{
    public class ClientConfig : Identify
    {
        public uint Shards { get; set; } = 1;
        public bool AutoSharding { get; set; } = true;
        public Action<Client> CachingConfig { get; set; }

        public ClientConfig()
        {
            Compress = true;
            Properties = new IdentifyProperties
            {
                OS = Environment.OSVersion.Platform.ToString(),
                Browser = "DiscordCs",
                Device = "DiscordCs"
            };
            LargeThreshold = 50;
            Presence = new PresenceStatusUpdate
            {
                Status = "online"
            };
            Intents = IdentifyIntent.Default;
            GuildSubscriptions = true;
        }

        public Identify GetIdentify(int[] shard)
        {
            return new Identify
            {
                Token = Token,
                Compress = Compress,
                GuildSubscriptions = GuildSubscriptions,
                Intents = Intents,
                LargeThreshold = LargeThreshold,
                Presence = Presence,
                Properties = Properties,
                Shard = shard
            };
        }
    }
}
