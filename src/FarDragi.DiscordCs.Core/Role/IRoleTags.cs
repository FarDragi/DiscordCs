namespace FarDragi.DiscordCs.Core.Role
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/permissions#role-object-role-tags-structure
    /// </summary>
    public interface IRoleTags
    {
        public ulong BotId { get; set; }
        public ulong IntegrationId { get; set; }
    }
}
