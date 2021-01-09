using FarDragi.DiscordCs.Core.Team;
using FarDragi.DiscordCs.Core.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Application
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/oauth2#application-object
    /// </summary>
    public interface IDiscordApplication
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string[] RpcOrigins { get; set; }
        public bool BotPublic { get; set; }
        public bool BotRequireCodeGrant { get; set; }
        public IDiscordUser Owner { get; set; }
        public string Summary { get; set; }
        public string VerifyKey { get; set; }
        public IDiscordTeam Team { get; set; }
        public ulong GuildId { get; set; }
        public ulong PrimarySkuId { get; set; }
        public string Slug { get; set; }
        public string CoverImage { get; set; }
        public int Flags { get; set; }
    }
}
