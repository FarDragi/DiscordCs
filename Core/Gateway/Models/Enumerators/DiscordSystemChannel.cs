using System;

namespace FarDragi.DragiCordApi.Core.Gateway.Models.Enumerators
{
    [Flags]
    internal enum DiscordSystemChannel : byte
    {
        SuppressJoinNotifications = 1,
        SuppressPremiumSubscriptions = 2
    }
}
