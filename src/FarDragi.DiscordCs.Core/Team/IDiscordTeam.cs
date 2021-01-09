using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Team
{
    public interface IDiscordTeam
    {
        public string Icon { get; set; }
        public ulong Id { get; set; }
    }
}
