using System;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Enums
{
    [Flags]
    internal enum DiscordActivityFlags
    {
        Instance = 1,
        Join = 2,
        Spectate = 4,
        JoinRequest = 8,
        Sync = 16,
        Play = 32
    }
}
