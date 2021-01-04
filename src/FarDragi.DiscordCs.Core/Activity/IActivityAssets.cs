using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Activity
{
    public interface IActivityAssets
    {
        public string LargeImage { get; set; }
        public string LargeText { get; set; }
        public string SmallImage { get; set; }
        public string SmallText { get; set; }
    }
}
