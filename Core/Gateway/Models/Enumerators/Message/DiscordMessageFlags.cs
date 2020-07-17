using System;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Enumerators.Message
{
    [Flags]
    internal enum DiscordMessageFlags
    {
        Crossposted = 1,
        IsCrosspost = 2,
        SuppressEmbeds = 4,
        SourceMessageDeleted = 8,
        Urgent = 16
    }
}
