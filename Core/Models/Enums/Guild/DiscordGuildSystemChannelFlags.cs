using System;

namespace FarDragi.DiscordCs.Core.Models.Enums.Guild
{
    [Flags]
    public enum DiscordGuildSystemChannelFlags : byte
    {
        SuppressJoinNotifications = 1,
        SuppressPremiumSubscriptions = 2
    }
}
