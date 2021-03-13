namespace FarDragi.DiscordCs.Logging
{
    public interface ILogger
    {
        public LoggingLevel Level { get; set; }
        public void Log(LoggingLevel level, string message);
    }
}
