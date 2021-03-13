using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entity.Interfaces
{
    public interface IDatas
    {
        public User User { get; }
        public GuildCollection Guilds { get; }
        public UserCollection Users { get; }
        public GuildChannelsCollection Channels { get; }
    }
}
