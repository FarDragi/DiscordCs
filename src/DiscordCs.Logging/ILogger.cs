using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Logging
{
    public interface ILogger
    {
        public LoggingLevel Level { get; set; }
        public void Log(LoggingLevel level, string message);
    }
}
