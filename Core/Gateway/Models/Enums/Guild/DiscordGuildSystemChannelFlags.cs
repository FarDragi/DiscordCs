using System;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Enums.Guild
{
    [Flags]
    internal enum DiscordGuildSystemChannelFlags : byte
    {
        SuppressJoinNotifications = 1,
        SuppressPremiumSubscriptions = 2
    }
}
