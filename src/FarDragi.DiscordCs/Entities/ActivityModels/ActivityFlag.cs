using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-flags
    /// </summary>
    [Flags]
    public enum ActivityFlag
    {
        None = 0,
        Instance = 1,
        Join = 2,
        Spectate = 4,
        JoinRequest = 8,
        Sync = 16,
        Play = 32
    }
}
