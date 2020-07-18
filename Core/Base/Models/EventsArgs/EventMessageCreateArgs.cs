using FarDragi.DiscordCs.Core.Base.Models.Event;

namespace FarDragi.DiscordCs.Core.Base.Models.EventsArgs
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
