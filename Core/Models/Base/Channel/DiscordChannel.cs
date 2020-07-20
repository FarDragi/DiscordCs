using FarDragi.DiscordCs.Core.Models.Collections;
using FarDragi.DiscordCs.Core.Models.Enumerators.Channel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Models.Base.Channel
{
    public class DiscordChannel
    {
        public ulong Id { get; set; }
        public DiscordChannelType Type { get; set; }
        public string Name { get; set; }
        public ulong GuildId { get; set; }
        public uint Position { get; set; }
        public ulong? ParentId { get; set; }
        public DiscordChannelOverritesList Overrites { get; set; }
    }
}
