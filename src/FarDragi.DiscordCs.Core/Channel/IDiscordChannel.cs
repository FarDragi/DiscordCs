using FarDragi.DiscordCs.Core.Permisson;
using FarDragi.DiscordCs.Core.User;
using System;

namespace FarDragi.DiscordCs.Core.Channel
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-channel-structure
    /// </summary>
    public interface IDiscordChannel
    {
        public ulong Id { get; set; }
        public int Type { get; set; }
        public ulong GuildId { get; set; }
        public int Position { get; set; }
        public IPermissionOverwrite[] PermissionOverwrites { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
        public bool Nsfw { get; set; }
        public ulong LastMessageId { get; set; }
        public int Bitrate { get; set; }
        public int UserLimit { get; set; }
        public int RateLimitPerUser { get; set; }
        public IDiscordUser[] Recipients { get; set; }
        public string Icon { get; set; }
        public ulong OwnerId { get; set; }
        public ulong ApplicationId { get; set; }
        public ulong ParentId { get; set; }
        public DateTime LastPinTimestamp { get; set; }
    }
}
