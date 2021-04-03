using System;

namespace FarDragi.DiscordCs.Entity.Models.UserModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/user#user-object-user-flags
    /// </summary>
    [Flags]
    public enum UserBadges
    {
        None = 0,
        DiscordEmployee = 1,
        PartneredServerOwner = 2,
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
        EarlyVerifiedBotDeveloper = 131072
    }
}
