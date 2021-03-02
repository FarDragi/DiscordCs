using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entity.Models.PresenceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#presence-update-presence-update-event-fields
    /// </summary>
    public class PresenceStatus
    {
        public const string Online = "online";
        public const string Dnd = "dnd";
        public const string Afk = "idle";
        public const string Invisible = "invisible";
        public const string Offline = "offline";
    }
}
