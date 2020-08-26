using FarDragi.DiscordCs.Core.Models.Base.Member;

namespace FarDragi.DiscordCs.Core.Models.Base.User
{
    public class DiscordUserMention : DiscordUser
    {
        public DiscordMember Member { get; set; }
    }
}
