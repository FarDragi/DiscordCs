using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.GuildModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#guild-object-verification-level
    /// </summary>
    public enum GuildVerificationLevel
    {
        None = 0,
        Low = 1,
        Medium = 2,
        High = 3,
        VeryHigh = 4
    }
}
