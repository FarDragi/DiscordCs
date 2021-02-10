using FarDragi.DiscordCs.Entities.PresenceModels;
using FarDragi.DiscordCs.Json.Entities.IdentifyModels;

namespace FarDragi.DiscordCs.Entities.IdentifyModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#identify-identify-structure
    /// </summary>
    public class Identify
    {
        public string Token { get; set; }
        public IdentifyProperties Properties { get; set; }
        public bool Compress { get; set; }
        public int LargeThreshold { get; set; }
        public int[] Shard { get; set; }
        public PresenceStatusUpdate Presence { get; set; }
        public bool GuildSubscriptions { get; set; }
        public IdentifyIntent Intents { get; set; }

        public static implicit operator JsonIdentify(Identify identify)
        {
            return new JsonIdentify
            {
                Token = identify.Token,
                Compress = identify.Compress,
                GuildSubscriptions = identify.GuildSubscriptions,
                Intents = (int)identify.Intents,
                LargeThreshold = identify.LargeThreshold,
                Presence = identify.Presence,
                Properties = identify.Properties,
                Shard = identify.Shard
            };
        }
    }
}
