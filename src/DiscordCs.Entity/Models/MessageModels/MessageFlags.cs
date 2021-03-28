using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entity.Models.MessageModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#message-object-message-flags
    /// </summary>
    [Flags]
    public enum MessageFlags
    {
        Crossposted = 1,
        IsCrosspost = 2,
        SuppressEmbeds = 4,
        SourceMessageDeleted = 8,
        Urgent = 16
    }
}
