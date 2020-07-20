using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Base.Channel
{
    public class DiscordTextChannel : DiscordChannel
    {
        public string Topic { get; set; }
        public bool IsNsfw { get; set; }
        public ulong LastMessageId { get; set; }
        public uint RateLimitPerUser { get; set; }
    }
}
