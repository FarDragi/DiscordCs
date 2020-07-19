using FarDragi.DiscordCs.Core.Models.Base.User;

namespace FarDragi.DiscordCs.Core.Models.Base.Emoji
{
    public class DiscordEmoji
    {
        public ulong? Id { get; set; }
        public string Name { get; set; }
        public ulong[] Roles { get; set; }
        public DiscordUser User { get; set; }
        public bool RequireColons { get; set; }
        public bool IsManaged { get; set; }
        public bool IsAnimated { get; set; }
        public bool IsAvailable { get; set; }
    }
}
