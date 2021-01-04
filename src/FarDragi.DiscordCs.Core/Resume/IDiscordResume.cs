using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Resume
{
    public interface IDiscordResume
    {
        public string Token { get; set; }
        public string SessionId { get; set; }
        public int Sequence { get; set; }
    }
}
