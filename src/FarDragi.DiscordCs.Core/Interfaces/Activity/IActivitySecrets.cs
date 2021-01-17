namespace FarDragi.DiscordCs.Core.Interfaces.Activity
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-secrets
    /// </summary>
    public interface IActivitySecrets
    {
        public string Join { get; set; }
        public string Spectate { get; set; }
        public string Match { get; set; }
    }
}
