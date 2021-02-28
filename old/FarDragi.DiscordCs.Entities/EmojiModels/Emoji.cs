using FarDragi.DiscordCs.Entities.UserModels;

namespace FarDragi.DiscordCs.Entities.EmojiModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/emoji#emoji-object-emoji-structure
    /// </summary>
    public class Emoji
    {
        public ulong? Id { get; set; }
        public string Name { get; set; }
        public string[] Roles { get; set; }
        public User User { get; set; }
        public bool RequireColons { get; set; }
        public bool Managed { get; set; }
        public bool Animated { get; set; }
        public bool Available { get; set; }
    }
}
