using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Interfaces.Activity
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-assets
    /// </summary>
    public interface IActivityAssets
    {
        public string LargeImage { get; set; }
        public string LargeText { get; set; }
        public string SmallImage { get; set; }
        public string SmallText { get; set; }
    }
}
