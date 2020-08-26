namespace FarDragi.DiscordCs.Core.Models.Base.Message
{
    public class DiscordMessageAttachment
    {
        public ulong Id { get; set; }
        public string Filename { get; set; }
        public uint Size { get; set; }
        public string Url { get; set; }
        public string ProxyUrl { get; set; }
        public uint? Height { get; set; }
        public uint? Width { get; set; }
    }
}
