using FarDragi.DiscordCs.Entities.IdentifyModels;
using FarDragi.DiscordCs.Entities.PresenceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs
{
    public class ClientConfig : Identify
    {
        public ClientConfig()
        {
            Compress = true;
            Properties = new IdentifyProperties
            {
                OS = Environment.OSVersion.Platform.ToString(),
                Browser = "DiscordCs",
                Device = "DiscordCs"
            };
            LargeThreshold = 250;
            Presence = new PresenceStatusUpdate
            {
                Since = 0,
                Status = "online"
            };
            Intents = IdentifyIntent.All;
        }
    }
}
