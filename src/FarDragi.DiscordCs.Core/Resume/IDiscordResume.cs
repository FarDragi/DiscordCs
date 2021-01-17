namespace FarDragi.DiscordCs.Core.Resume
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#resume-example-resume
    /// </summary>
    public interface IDiscordResume
    {
        public string Token { get; set; }
        public string SessionId { get; set; }
        public int Sequence { get; set; }
    }
}
