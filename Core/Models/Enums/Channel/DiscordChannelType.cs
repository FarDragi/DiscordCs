using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Enums.Channel
{
    public enum DiscordChannelType : byte
    {
        GuildText = 0,
        Dm = 1,
        GuildVoice = 2,
        GroupDm = 3,
        GuildCategory = 4,
        GuildNews = 5,
        GuildStore = 6
    }
}
