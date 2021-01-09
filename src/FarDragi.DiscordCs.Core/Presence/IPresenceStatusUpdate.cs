using FarDragi.DiscordCs.Core.Activity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Presence
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#update-status-gateway-status-update-structure
    /// </summary>
    public interface IPresenceStatusUpdate
    {
        public int Since { get; set; }
        public IDiscordActivity Activities { get; set; }
        public string Status { get; set; }
        public bool Afk { get; set; }
    }
}
