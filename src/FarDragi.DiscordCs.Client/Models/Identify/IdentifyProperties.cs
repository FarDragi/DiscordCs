using FarDragi.DiscordCs.Core.Json.Models.Identify;

namespace FarDragi.DiscordCs.Client.Models.Identify
{
    public class IdentifyProperties
    {
        public string OS { get; set; }
        public string Browser { get; set; }
        public string Device { get; set; }

        public static implicit operator IdentifyProperties(IdentifyPropertiesBase propertiesBase)
        {
            return new IdentifyProperties
            {
                OS = propertiesBase.OS,
                Browser = propertiesBase.Browser,
                Device = propertiesBase.Device
            };
        }

        public static implicit operator IdentifyPropertiesBase(IdentifyProperties properties)
        {
            return new IdentifyPropertiesBase
            {
                OS = properties.OS,
                Browser = properties.Browser,
                Device = properties.Device
            };
        }
    }
}
