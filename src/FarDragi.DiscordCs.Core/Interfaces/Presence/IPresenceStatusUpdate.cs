using FarDragi.DiscordCs.Core.Interfaces.Activity;

namespace FarDragi.DiscordCs.Core.Interfaces.Presence
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#update-status-gateway-status-update-structure
    /// </summary>
    public interface IPresenceStatusUpdate
    {
        public int Since { get; set; }
        public IDiscordActivity Activities { get; set; }
        public string Status { get; set; }
        public bool Afk { get; set; }
    }
}
