using FarDragi.DiscordCs.Core.Presence;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Identify
{
    public interface IDiscordIdentify
    {
        public string Token { get; set; }
        public IIdentifyProperties Properties { get; set; }
        public bool Compress { get; set; }
        public int LargeThreshold { get; set; }
        public int[] Shard { get; set; }
        public IDiscordPresence Presence { get; set; }
        public bool GuildSubscriptions { get; set; }
        public int Intents { get; set; }
    }
}
