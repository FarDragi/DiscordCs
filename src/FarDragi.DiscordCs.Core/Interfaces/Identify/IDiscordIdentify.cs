using FarDragi.DiscordCs.Core.Interfaces.Presence;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Interfaces.Identify
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#identify-identify-structure
    /// </summary>
    public interface IDiscordIdentify
    {
        public string Token { get; set; }
        public IIdentifyProperties Properties { get; set; }
        public bool Compress { get; set; }
        public int LargeThreshold { get; set; }
        public int[] Shard { get; set; }
        public IPresenceStatusUpdate Presence { get; set; }
        public bool GuildSubscriptions { get; set; }
        public int Intents { get; set; }
    }
}
