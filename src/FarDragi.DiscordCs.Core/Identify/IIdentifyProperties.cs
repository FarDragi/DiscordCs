namespace FarDragi.DiscordCs.Core.Identify
{
    public interface IIdentifyProperties
    {
        public string OS { get; set; }
        public string Browser { get; set; }
        public string Device { get; set; }
    }
}
