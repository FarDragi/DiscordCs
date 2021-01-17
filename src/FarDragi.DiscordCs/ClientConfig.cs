using FarDragi.DiscordCs.Entities.IdentifyModels;
using FarDragi.DiscordCs.Entities.PresenceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs
{
    public class ClientConfig : Identify
    {
        public uint Shards { get; set; } = 1;
        public bool AutoSharding { get; set; } = true;

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
