using FarDragi.DiscordCs.Core.Models.Event;

namespace FarDragi.DiscordCs.Core.Models.EventsArgs
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
