using System;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Enumerators
{
    [Flags]
    internal enum DiscordBadges
    {
        None = 0,
        DiscordEmployee = 1,
        DiscordPartner = 2,
        HypeSquadEvents = 4,
        BugHunterLevel1 = 8,
        HouseBravery = 64,
        HouseBrilliance = 128,
        HouseBalance = 256,
        EarlySupporter = 512,
        TeamUser = 1024,
        System = 4096,
        BugHunterLevel2 = 16384,
        VerifiedBot = 65536,
        VerifiedBotDeveloper = 131072
    }
}
