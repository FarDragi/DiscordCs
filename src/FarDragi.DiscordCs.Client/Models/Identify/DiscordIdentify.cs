using FarDragi.DiscordCs.Client.Models.Presence;
using FarDragi.DiscordCs.Core.Json.Models.Identify;

namespace FarDragi.DiscordCs.Client.Models.Identify
{
    public class DiscordIdentify
    {
        public string Token { get; set; }
        public IdentifyProperties Properties { get; set; }
        public bool Compress { get; set; } = true;
        public int LargeThreshold { get; set; } = 250;
        public int[] Shard { get; set; }
        public PresenceStatusUpdate Presence { get; set; }
        public bool GuildSubscriptions { get; set; }
        public int Intents { get; set; } = 32509;

        public static implicit operator DiscordIdentify(DiscordIdentifyBase identifyBase)
        {
            return new DiscordIdentify
            {
                Token = identifyBase.Token,
                Properties = identifyBase.Properties,
                Compress = identifyBase.Compress,
                LargeThreshold = identifyBase.LargeThreshold,
                Shard = identifyBase.Shard,
                Presence = identifyBase.Presence,
                GuildSubscriptions = identifyBase.GuildSubscriptions,
                Intents = identifyBase.Intents
            };
        }

        public static implicit operator DiscordIdentifyBase(DiscordIdentify identify)
        {
            return new DiscordIdentifyBase
            {
                Token = identify.Token,
                Properties = identify.Properties,
                Compress = identify.Compress,
                LargeThreshold = identify.LargeThreshold,
                Shard = identify.Shard,
                Presence = identify.Presence,
                GuildSubscriptions = identify.GuildSubscriptions,
                Intents = identify.Intents
            };
        }
    }
}
