using FarDragi.DiscordCs.Core.Guild;

namespace FarDragi.DiscordCs.Core.Voice
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/voice#voice-state-object-voice-state-structure
    /// </summary>
    public interface IDiscordVoice
    {
        public ulong GuildId { get; set; }
        public ulong ChannelId { get; set; }
        public ulong UserId { get; set; }
        public IGuildMember Member { get; set; }
        public string SessionId { get; set; }
        public bool Deaf { get; set; }
        public bool Mute { get; set; }
        public bool SelfDeaf { get; set; }
        public bool SelfMute { get; set; }
        public bool SelfStream { get; set; }
        public bool SelfVideo { get; set; }
        public bool Suppress { get; set; }
    }
}
