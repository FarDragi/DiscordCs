namespace FarDragi.DiscordCs.Core.Team
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/teams#data-models-team-object
    /// </summary>
    public interface IDiscordTeam
    {
        public string Icon { get; set; }
        public ulong Id { get; set; }
        public ITeamMember[] Members { get; set; }
        public ulong OwnerUserId { get; set; }
    }
}
