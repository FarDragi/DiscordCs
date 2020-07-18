namespace FarDragi.DiscordCs.Core.Models.Base.Guild
{
    public class DiscordGuildAfkConfig
    {
        public ulong? AfkChannelId { get; set; }
        public uint AfkTimeout { get; set; }
    }
}
