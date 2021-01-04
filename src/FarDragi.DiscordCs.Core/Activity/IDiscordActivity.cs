using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Activity
{
    public interface IDiscordActivity
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public string Url { get; set; }
        public int CreatedAt { get; set; }
        public IActivityTimestamps Timestamps { get; set; }
        public ulong ApplicationId { get; set; }
        public string Details { get; set; }
        public string State { get; set; }
        public IActivityEmoji Emoji { get; set; }
        public IActivityParty Party { get; set; }
        public IActivityAssets Assets { get; set; }
        public IActivitySecrets Secrets { get; set; }
        public bool Instance { get; set; }
        public int Flags { get; set; }
    }
}
