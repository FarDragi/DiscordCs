using FarDragi.DiscordCs.Core.Models.Base.Member;

namespace FarDragi.DiscordCs.Core.Models.Base.Voice
{
    public class DiscordVoice
    {
        public ulong GuildId { get; set; }
        public ulong? ChannelId { get; set; }
        public ulong UserId { get; set; }
        public DiscordMember Member { get; set; }
        public string SessionId { get; set; }
        public bool IsDeaf { get; set; }
        public bool IsMute { get; set; }
        public bool IsSelfDeaf { get; set; }
        public bool IsSelfMute { get; set; }
        public bool IsSelfStream { get; set; }
        public bool IsSuppress { get; set; }
    }
}
