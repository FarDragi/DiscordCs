using FarDragi.DiscordCs.Entities.PermissionModels;
using FarDragi.DiscordCs.Entities.UserModels;
using System;

namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-channel-structure
    /// </summary>
    public class Channel
    {
        public ulong Id { get; set; }
        public ChannelTypes Type { get; set; }
        public ulong GuildId { get; set; }
        public int Position { get; set; }
        public PermissionOverwrite[] PermissionOverwrites { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
        public bool Nsfw { get; set; }
        public ulong? LastMessageId { get; set; }
        public int Bitrate { get; set; }
        public int UserLimit { get; set; }
        public int RateLimitPerUser { get; set; }
        public User[] Recipients { get; set; }
        public string Icon { get; set; }
        public ulong OwnerId { get; set; }
        public ulong ApplicationId { get; set; }
        public ulong ParentId { get; set; }
        public DateTime LastPinTimestamp { get; set; }
    }
}
