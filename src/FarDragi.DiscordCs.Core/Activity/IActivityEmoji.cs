using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Activity
{
    public interface IActivityEmoji
    {
        public string Name { get; set; }
        public ulong? Id { get; set; }
        public bool animated { get; set; }
    }
}
