using System;

namespace FarDragi.DragiCordApi.Core.Gateway.Models.Enumerators
{
    [Flags]
    public enum DiscordSystemChannel : byte
    {
        SuppressJoinNotifications = 1,
        SuppressPremiumSubscriptions = 2
    }
}
