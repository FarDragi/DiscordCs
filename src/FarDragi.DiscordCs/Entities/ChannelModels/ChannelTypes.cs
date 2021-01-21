using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-channel-types
    /// </summary>
    public enum ChannelTypes
    {
        GuildText = 0,
        DirectMessage = 1,
        GuildVoice = 2,
        GroupDirectMessage = 3,
        GuildCategory = 4,
        GuildNews = 5,
        GuildStore = 6
    }
}
