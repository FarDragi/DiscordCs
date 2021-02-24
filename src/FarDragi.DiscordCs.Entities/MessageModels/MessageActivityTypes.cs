using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.MessageModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#message-object-message-activity-types
    /// </summary>
    public enum MessageActivityTypes
    {
        Join = 1,
        Spectate = 2,
        Listen = 3,
        JoinRequest = 5
    }
}
