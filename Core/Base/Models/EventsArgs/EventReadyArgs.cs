using FarDragi.DiscordCs.Core.Base.Models.Event;

namespace FarDragi.DiscordCs.Core.Base.Models.EventsArgs
{
    public class EventReadyArgs
    {
        public Ready Data { get; set; }

        public EventReadyArgs(Ready ready)
        {
            Data = ready;
        }
    }
}
