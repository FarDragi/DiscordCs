using FarDragi.DiscordCs.Core.Models.Base.Emoji;
using FarDragi.DiscordCs.Core.Models.Enums.Activity;

namespace FarDragi.DiscordCs.Core.Models.Base.Activity
{
    public class DiscordActivity
    {
        public string Name { get; set; }
        public DiscordActivityType Type { get; set; }
        public string Url { get; set; }
        public ulong CreatedAt { get; set; }
        public DiscordActivityTimestamp Timestamps { get; set; }
        public ulong ApplicationId { get; set; }
        public string Details { get; set; }
        public string State { get; set; }
        public DiscordEmoji Emoji { get; set; }
        public DiscordActivityParty Party { get; set; }
        public DiscordActivityAssets Assets { get; set; }
        public DiscordActivitySecrets Secrets { get; set; }
        public bool IsInstance { get; set; }
        public DiscordActivityFlags Flags { get; set; }
    }
}
