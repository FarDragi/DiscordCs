using FarDragi.DiscordCs.Core.Models.Base.Emoji;

namespace FarDragi.DiscordCs.Core.Models.Base.Message
{
    public class DiscordMessageReaction
    {
        public uint Count { get; set; }
        public bool IsMe { get; set; }
        public DiscordEmoji Emoji { get; set; }
    }
}
