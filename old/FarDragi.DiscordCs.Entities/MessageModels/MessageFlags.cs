using System;

namespace FarDragi.DiscordCs.Entities.MessageModels
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
