using FarDragi.DiscordCs.Core.Base.Models.Event;

namespace FarDragi.DiscordCs.Core.Base.Models.EventsArgs
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
