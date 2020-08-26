using FarDragi.DiscordCs.Core.Client;
using FarDragi.DiscordCs.Core.Models.Event;

namespace FarDragi.DiscordCs.Core.Models.EventsArgs
{
    public class EventGuildCreateArgs
    {
        public GuildCreate Data { get; }
        public DiscordClient Client { get; }

        internal EventGuildCreateArgs(GuildCreate guildCreate, DiscordClient client)
        {
            Data = guildCreate;
            Client = client;
        }
    }
}
