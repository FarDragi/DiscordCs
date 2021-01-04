using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Activity
{
    public interface IActivityParty
    {
        public string Id { get; set; }
        public int[] Size { get; set; }
    }
}
