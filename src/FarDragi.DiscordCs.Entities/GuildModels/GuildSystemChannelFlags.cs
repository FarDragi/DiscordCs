using System;

namespace FarDragi.DiscordCs.Entities.GuildModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#guild-object-system-channel-flags
    /// </summary>
    [Flags]
    public enum GuildSystemChannelFlags
    {
        SuppressJoinNotifications = 1,
        SuppressPremiumSubscriptions = 2
    }
}
