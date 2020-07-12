using FarDragi.DiscordCs.Core.Base.Models.Base;

namespace FarDragi.DiscordCs.Core.Base.Models.Event
{
    public class Ready
    {
        public uint Version { get; set; }
        public DiscordUser User { get; set; }
        public DiscordGuild[] Guilds { get; set; }
        public string SessionId { get; set; }
        public DiscordShards Shards { get; set; }
    }
}
