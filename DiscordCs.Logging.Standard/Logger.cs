using Pastel;
using System;
using System.Drawing;

namespace FarDragi.DiscordCs.Logging.Standard
{
    public class Logger : ILogger
    {
        private const string DateColor = "#08b1e2";
        private const string DcsColor = "#24ae91";
        private const string InfoColor = "#8dc748";
        private const string WarningColor = "#ffc20e";
        private const string ErrorColor = "#ca3431";
        private const string VerboseColor = "#804b9d";
        private const string SeveriryColor = "#e93519";

        public LoggingLevel Level { get; set; }

        public void Log(LoggingLevel level, string message)
        {
            if (level > Level)
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
                case LoggingLevel.Severity:
                    Console.WriteLine("{0} {1} --> {2}", messageDate, "[ Sev ]".Pastel(Color.Black).PastelBg(SeveriryColor), message);
                    break;
                default:
                    break;
            }
        }
    }
}
