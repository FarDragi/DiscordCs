using Pastel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FarDragi.DiscordCs.Logging.Standard
{
    public class LoggerStandard : ILogger
    {
        private LoggingLevel _level;

        public LoggingLevel Level { get => _level;  set => _level = value; }

        public void Log(LoggingLevel level, string message)
        {
            if (level > _level)
            {
                return;
            }

            DateTime now = DateTime.Now;
            message = $"[{now:G}] [{level,-7}] : {message}";

            switch (level)
            {
                case LoggingLevel.Info:
                    Console.WriteLine(message.Pastel(Color.Violet));
                    break;
                case LoggingLevel.Warning:
                    Console.WriteLine(message.Pastel(Color.Yellow));
                    break;
                case LoggingLevel.Error:
                    Console.WriteLine(message.Pastel(Color.IndianRed));
                    break;
                case LoggingLevel.Verbose:
                    Console.WriteLine(message);
                    break;
                default:
                    break;
            }
        }
    }
}
