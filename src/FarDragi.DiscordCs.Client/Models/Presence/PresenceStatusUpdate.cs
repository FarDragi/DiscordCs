using FarDragi.DiscordCs.Core.Interfaces.Activity;
using FarDragi.DiscordCs.Core.Json.Models.Presence;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Client.Models.Presence
{
    public class PresenceStatusUpdate
    {
        public int Since { get; set; } = 0;
        public IDiscordActivity Activities { get; set; }
        public string Status { get; set; } = "online";
        public bool Afk { get; set; }

        public static implicit operator PresenceStatusUpdate(PresenceStatusUpdateBase statusUpdateBase)
        {
            return new PresenceStatusUpdate
            {
                Since = statusUpdateBase.Since,
                Status = statusUpdateBase.Status,
                Afk = statusUpdateBase.Afk
            };
        }

        public static implicit operator PresenceStatusUpdateBase(PresenceStatusUpdate statusUpdate)
        {
            return new PresenceStatusUpdateBase
            {
                Since = statusUpdate.Since,
                Status = statusUpdate.Status,
                Afk = statusUpdate.Afk
            };
        }
    }
}
