using FarDragi.DiscordCs.Core.Models.Event;

namespace FarDragi.DiscordCs.Core.Models.EventsArgs
{
    public class EventGuildCreateArgs
    {
        public GuildCreate Data { get; }

        internal EventGuildCreateArgs(GuildCreate guildCreate)
        {
            Data = guildCreate;
        }
    }
}
