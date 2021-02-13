using FarDragi.DiscordCs.Entities.PermissionModels;
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
        public PermissionOverwriteCollection PermissionOverwrites { get; set; }
        public string Name { get; set; }
        public bool Nsfw { get; set; }
        public ulong? ParentId { get; set; }
        public GuildCategory Parent { get; set; }
        public DateTime LastPinTimestamp { get; set; }
    }
}
