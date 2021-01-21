using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.PresenceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#client-status-object
    /// </summary>
    public class PresenceClientStatus
    {
        public string Desktop { get; set; }
        public string Mobile { get; set; }
        public string Web { get; set; }
    }
}
