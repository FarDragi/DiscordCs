using System;

namespace FarDragi.DiscordCs.Core.Models.Enums.Message
{
    [Flags]
    public enum DiscordMessageFlags
    {
        Crossposted = 1,
        IsCrosspost = 2,
        SuppressEmbeds = 4,
        SourceMessageDeleted = 8,
        Urgent = 16
    }
}
