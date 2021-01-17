using FarDragi.DiscordCs.Json.Entities.IdentifyModels;

namespace FarDragi.DiscordCs.Entities.IdentifyModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#identify-identify-connection-properties
    /// </summary>
    public class IdentifyProperties
    {
        public string OS { get; set; }
        public string Browser { get; set; }
        public string Device { get; set; }

        public static implicit operator JsonIdentifyProperties(IdentifyProperties identifyProperties)
        {
            return new JsonIdentifyProperties
            {
                Browser = identifyProperties.Browser,
                Device = identifyProperties.Device,
                OS = identifyProperties.OS
            };
        }
    }
}
