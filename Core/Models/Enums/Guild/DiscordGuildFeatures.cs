using System;

namespace FarDragi.DiscordCs.Core.Models.Enums.Guild
{
    [Flags]
    public enum DiscordGuildFeatures
    {
        None = 0,
        InviteSplash = 1,
        VipRegions = 2,
        VanityUrl = 4,
        Verified = 8,
        Partnered = 16,
        Public = 32,
        Commerce = 64,
        News = 128,
        Discoverable = 256,
        Featurable = 512,
        AnimatedIcon = 1024,
        Banner = 2048,
        PublicDisabled = 4096,
        WelcomeScreenEnabled = 8192
    }
}
