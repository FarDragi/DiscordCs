using FarDragi.DiscordCs.Core.Application;
using FarDragi.DiscordCs.Core.Guild;
using FarDragi.DiscordCs.Core.User;

namespace FarDragi.DiscordCs.Core.Ready
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#ready-ready-event-fields
    /// </summary>
    interface IDiscordReady
    {
        public int Vesion { get; set; }
        public IDiscordUser User { get; set; }
        public IDiscordGuild[] Guilds { get; set; }
        public string SessionId { get; set; }
        public int[] Shard { get; set; }
        public IDiscordApplication Application { get; set; }
    }
}
