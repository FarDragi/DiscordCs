using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.GuildModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#guild-object-default-message-notification-level
    /// </summary>
    public enum GuildMessageNotificationLevel
    {
        AllMessages = 0,
        OnlyMentions = 1
    }
}
