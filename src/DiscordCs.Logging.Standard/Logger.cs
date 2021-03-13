using Pastel;
using System;

namespace FarDragi.DiscordCs.Logging.Standard
{
    public class Logger : ILogger
    {
        private LoggingLevel _level;
        private const string DateColor = "#08b1e2";
        private const string DcsColor = "#24ae91";
        private const string InfoColor = "#8dc748";
        private const string WarningColor = "#ffc20e";
        private const string ErrorColor = "#ca3431";
        private const string VerboseColor = "#804b9d";

        public LoggingLevel Level { get => _level; set => _level = value; }

        public void Log(LoggingLevel level, string message)
        {
            if (level > _level)
            {
                return;
            }

            DateTime now = DateTime.Now;
            string messageDate = $"[{now:G}]".Pastel(DateColor);

            switch (level)
            {
                case LoggingLevel.Dcs:
                    Console.WriteLine("{0} {1} --> {2}", messageDate, "[ Dcs ]".Pastel(DcsColor), message);
                    break;
                case LoggingLevel.Info:
                    Console.WriteLine("{0} {1} --> {2}", messageDate, "[ Inf ]".Pastel(InfoColor), message);
                    break;
                case LoggingLevel.Warning:
                    Console.WriteLine("{0} {1} --> {2}", messageDate, "[ War ]".Pastel(WarningColor), message);
                    break;
                case LoggingLevel.Error:
                    Console.WriteLine("{0} {1} --> {2}", messageDate, "[ Err ]".Pastel(ErrorColor), message);
                    break;
                case LoggingLevel.Verbose:
                    Console.WriteLine("{0} {1} --> {2}", messageDate, "[ Veb ]".Pastel(VerboseColor), message);
                    break;
                default:
                    break;
            }
        }
    }
}
