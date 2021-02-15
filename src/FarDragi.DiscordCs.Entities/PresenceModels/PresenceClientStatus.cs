using FarDragi.DiscordCs.Json.Entities.PresenceModels;

namespace FarDragi.DiscordCs.Entities.PresenceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#client-status-object
    /// </summary>
    public class PresenceClientStatus
    {
        public string Desktop { get; set; }
        public string Mobile { get; set; }
        public string Web { get; set; }

        public static implicit operator PresenceClientStatus(JsonPresenceClientStatus json)
        {
            return new PresenceClientStatus
            {
                Desktop = json.Desktop,
                Mobile = json.Mobile,
                Web = json.Web
            };
        }
    }
}
