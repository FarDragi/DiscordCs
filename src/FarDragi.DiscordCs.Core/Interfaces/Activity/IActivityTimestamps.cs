namespace FarDragi.DiscordCs.Core.Interfaces.Activity
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-timestamps
    /// </summary>
    public interface IActivityTimestamps
    {
        public int? Start { get; set; }
        public int? End { get; set; }
    }
}
