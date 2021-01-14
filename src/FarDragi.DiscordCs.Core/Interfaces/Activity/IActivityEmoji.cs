using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Interfaces.Activity
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-emoji
    /// </summary>
    public interface IActivityEmoji
    {
        public string Name { get; set; }
        public ulong? Id { get; set; }
        public bool animated { get; set; }
    }
}
