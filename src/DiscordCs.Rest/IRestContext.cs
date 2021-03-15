using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Rest
{
    public interface IRestContext
    {
        public IRestConfig Config { get; }
    }
}
