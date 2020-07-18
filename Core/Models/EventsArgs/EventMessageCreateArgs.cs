using FarDragi.DiscordCs.Core.Models.Event;

namespace FarDragi.DiscordCs.Core.Models.EventsArgs
{
    public class EventMessageCreateArgs
    {
        public MessageCreate Data { get; }

        internal EventMessageCreateArgs(MessageCreate messageCreate)
        {
            Data = messageCreate;
        }
    }
}
