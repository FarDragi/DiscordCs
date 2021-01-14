using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Interfaces.Activity
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-party
    /// </summary>
    public interface IActivityParty
    {
        public string Id { get; set; }
        public int[] Size { get; set; }
    }
}
