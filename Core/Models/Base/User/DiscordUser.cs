using FarDragi.DiscordCs.Core.Models.Enums.User;

namespace FarDragi.DiscordCs.Core.Models.Base.User
{
    public class DiscordUser
    {
        public ulong Id { get; set; }
        public string Username { get; set; }
        public string Discriminator { get; set; }
        public string Avatar { get; set; }
        public bool IsBot { get; set; }
        public bool IsSystem { get; set; }
        public bool MfaEnabled { get; set; }
        public string Locale { get; set; }
        public bool IsVerified { get; set; }
        public string Email { get; set; }
        public DiscordUserBadges Badges { get; set; }
        public DiscordUserPremiumType PremiumType { get; set; }
    }
}
