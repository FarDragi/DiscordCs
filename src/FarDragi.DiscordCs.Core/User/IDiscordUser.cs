namespace FarDragi.DiscordCs.Core.User
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/user#user-object-user-structure
    /// </summary>
    public interface IDiscordUser
    {
        public ulong Id { get; set; }
        public string UserName { get; set; }
        public string Discriminator { get; set; }
        public string Avatar { get; set; }
        public bool Bot { get; set; }
        public bool System { get; set; }
        public bool MfaEnabled { get; set; }
        public bool Locale { get; set; }
        public bool Verified { get; set; }
        public string Email { get; set; }
        public int Flags { get; set; }
        public int PremiumType { get; set; }
        public int PublicFlags { get; set; }
    }
}
