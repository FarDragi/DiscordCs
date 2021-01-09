using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Presence
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#client-status-object
    /// </summary>
    public interface IPresenceClientStatus
    {
        public string Desktop { get; set; }
        public string Mobile { get; set; }
        public string Web { get; set; }
    }
}
