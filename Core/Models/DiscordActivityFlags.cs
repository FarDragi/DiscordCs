using System;

namespace FarDragi.DragiCordApi.Core.Models
{
    [Flags]
    public enum DiscordActivityFlags
    {
        Instance = 1 << 0,
        Join = 1 << 1,
        Spectate = 1 << 2,
        JoinRequest = 1 << 3,
        Sync = 1 << 4,
        Play = 1 << 5
    }
}
