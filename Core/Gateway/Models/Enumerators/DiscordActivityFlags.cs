using System;

namespace FarDragi.DragiCordApi.Core.Gateway.Models.Enumerators
{
    [Flags]
    public enum DiscordActivityFlags
    {
        Instance = 1,
        Join = 2,
        Spectate = 4,
        JoinRequest = 8,
        Sync = 16,
        Play = 32
    }
}
