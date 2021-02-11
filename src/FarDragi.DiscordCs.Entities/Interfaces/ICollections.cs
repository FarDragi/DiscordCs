using FarDragi.DiscordCs.Entities.GuildModels;
using FarDragi.DiscordCs.Entities.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.Interfaces
{
    public interface ICollections
    {
        public GuildCollection Guilds { get; set; }
        public UserCollection Users { get; set; }
    }
}
