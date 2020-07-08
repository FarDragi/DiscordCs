using System;

namespace FarDragi.DragiCordApi.Core.Models
{
    [Flags]
    public enum DiscordGuildSystemChannelFlags : byte
    {
        SuppressJoinNotifications = 0x1,
        SuppressPremiumSubscriptions = 0x2
    }
}
