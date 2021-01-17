namespace FarDragi.DiscordCs.Core.Interfaces.Identify
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#identify-identify-connection-properties
    /// </summary>
    public interface IIdentifyProperties
    {
        public string OS { get; set; }
        public string Browser { get; set; }
        public string Device { get; set; }
    }
}
